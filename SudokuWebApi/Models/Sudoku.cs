using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApi.Models
{
    public class Sudoku
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SpaghettiString { get; set; }
    }
}
