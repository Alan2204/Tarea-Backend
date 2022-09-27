using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebApiPc.Controllers
{
    [ApiController]
    [Route("Marcas")]
    public class MarcasController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public MarcasController (ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }

        [HttpGet]
        public async Task<ActionResult<List<Marca>>> GetAll()
        {
            return await dbContext.marcas.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Marca>> GetById(int id)
        {
            return await dbContext.marcas.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Marca marca)
        {
            var existeModelo = await dbContext.Computadoras.AnyAsync(x => x.Id == marca.ModeloID);

            if(!existeModelo)
            {
                return BadRequest($"No existe el modelo con el id: {marca.ModeloID}");
            }

            dbContext.Add(marca);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Marca>> Put(Marca marca, int id)
        {
            var exist = await dbContext.marcas.AnyAsync(x => x.Id == id);
            if(!exist)
            {
                return BadRequest("La marca especifica no existe");
            }
            if(marca.Id != id)
            {
                return BadRequest("El id de la marca no coincide con lo establecido en la url. ");
            }
            dbContext.Update(marca);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.marcas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("El recurso no fue encontrado. ");
            }

            dbContext.Remove(new Marca { Id = id });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
