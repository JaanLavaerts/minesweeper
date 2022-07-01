using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cells;
using Model.Data;

namespace ViewModel
{
    public class RowViewModel
    {

        public IEnumerable<SquareViewModel> Squares
        {
            get;
        }

        public RowViewModel(ICell<IGame> game, int rowIndex)
        {
            this.Squares = Row(game, rowIndex);
        }

        public IEnumerable<SquareViewModel> Row(ICell<IGame> game, int rowIndex)
        {

            var board = game.Derive(x => x.Board);
            var width = board.Value.Width;
            var res = new List<SquareViewModel>();

            for (int i = 0; i < width; i++)
            {
                res.Add(new SquareViewModel(game, new Vector2D(i, rowIndex)));
            }
            return res;

        }

    }
}
