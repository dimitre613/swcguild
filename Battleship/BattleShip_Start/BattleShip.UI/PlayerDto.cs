using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;

namespace BattleShip.UI
{
    public class PlayerDto
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public bool isTurn { get; set; }  // not used as of yet...


        public PlayerDto()
        {
            Board = new Board();
            isTurn = false;
        }

    }
}
