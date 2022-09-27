using WebApiPc.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiPc.Controllers
{
    [ApiController] 
    [Route("Laptops")] //es la ruta del controlador
    public class PcController: ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PcController(ApplicationDbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        [HttpGet] 
        public async Task<List<Computadora>> Get()
        {
            return await dbContext.Computadoras.ToListAsync(); 
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Computadora>> Get(int id)
        {
            var computadora = await dbContext.Computadoras.FirstOrDefaultAsync(x => x.Id == id);

            if(computadora == null)
            {
                return NotFound();
            }
            return computadora;
        }

        [HttpGet("{Modelo}")] //se define automaticamente como string al no agregarle el tipo de valor
        public async Task<ActionResult<Computadora>> Get(string modelo)
        {
            var computadora = await dbContext.Computadoras.FirstOrDefaultAsync(x => x.Modelo.Contains(modelo));
            
            //El condicional no se hara hasta que la peticion del await se complete.
            if (computadora == null)
            {
                return NotFound();
            }
            return computadora;
        }

        [HttpPost]

        public async Task<ActionResult> Post(Computadora computadora)
        {
            dbContext.Add(computadora);
            await dbContext.SaveChangesAsync(); 
            return Ok();
        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(Computadora computadora, int id)
        {
            if(computadora.Id != id) 
            {
                return BadRequest("El id no coincide.");
            }

            dbContext.Update(computadora);
            await dbContext.SaveChangesAsync(); 
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Computadoras.AnyAsync(x => x.Id == id);
            if(!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Computadora()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }


}
