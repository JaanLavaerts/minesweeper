using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        private readonly ICell<IGameBoard> gameBoard;

        public IEnumerable<RowViewModel> Rows
        {
            get;
        }

        public GameBoardViewModel(ICell<IGame> game)
        {
            this.gameBoard = game.Derive(x => x.Board);
            this.Rows = RowsM(game);
        }

        public IEnumerable<RowViewModel> RowsM(ICell<IGame> game)
        {

            var board = gameBoard.Value;
            var height = board.Height;
            var res = new List<RowViewModel>();

            for (int i = 0; i < height; i++)
            {
                res.Add(new RowViewModel(game, i));
            }
            return res;
        
        }
    }
}
