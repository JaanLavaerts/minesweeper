using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameViewModel
    {

        // public ICell<IGame> IGame
        // {
        //     get;
        // }

        public GameBoardViewModel GameBoard
        {
            get;
        }

        public GameViewModel(IGame game)
        {
            var currentGame = Cell.Create(game);
            this.GameBoard = new GameBoardViewModel(currentGame);
        }

    }
}
