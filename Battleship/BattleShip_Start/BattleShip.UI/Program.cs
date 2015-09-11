using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// v1.09.10.15+1
/// </summary>


namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new BattleshipGame();

            game.PlayGame();

        }

    }
}

