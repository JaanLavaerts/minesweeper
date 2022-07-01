using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cells;

namespace ViewModel
{
    public class FlagSquareCommand : ICommand
    {

        private ICell<IGame> game;
        private Vector2D position;

        public FlagSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.game = game;
            this.position = position;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            if (!game.Value.IsSquareCovered(position) || game.Value.Status == GameStatus.Lost)
            {
                return false;
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            game.Value = game.Value.ToggleFlag(position);
        }
    }
}
