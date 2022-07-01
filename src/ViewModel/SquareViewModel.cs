using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cells;

namespace ViewModel
{
    public class SquareViewModel
    {

        public ICommand Uncover
        {
            get;
        }

        public ICommand Flag
        {
            get;
        }

        public ICell<Square> Square
        {
            get;
        }

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.Square = game.Derive(x => x.Board).Derive(x => x[position]);
            this.Uncover = new UncoverSquareCommand(game, position);
            this.Flag = new FlagSquareCommand(game, position);
        }

    }
}
