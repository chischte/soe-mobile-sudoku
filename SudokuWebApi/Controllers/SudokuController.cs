using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SudokuWebApi.Models;

namespace SudokuWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IList<Sudoku> sudokuList = new List<Sudoku>();
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
           //_logger = logger;
            this.sudokuList.Add(new Sudoku() { Id = 0, Name = "beginner", SpaghettiString = "302080105007200060508900047080400302030160058010500670020345001000026009000090526" });
            this.sudokuList.Add(new Sudoku() { Id = 1, Name = "intermediate", SpaghettiString = "801003906009007850250100470500061704760830000032000000020019500005000302000452197" });
            this.sudokuList.Add(new Sudoku() { Id = 2, Name = "advanced", SpaghettiString = "407103000910000000600004090130000005098002700700058200000000073009076050000405000" });
            this.sudokuList.Add(new Sudoku() { Id = 3, Name = "expert", SpaghettiString = "080030006050049300000000000000400001700208000106000040078002000000000209409005000" });
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sudoku>> GetElements()
        {
            return Ok(sudokuList);
        }

        [HttpPost]
        public ActionResult<Sudoku> PostElement(Sudoku value)
        {
            sudokuList.Add(value);

            return CreatedAtAction(nameof(GetElements), new { id = value.Id }, value);
        }
    }
}
