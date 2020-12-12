using System;
using System.Collections.Generic;
using System.Text;

namespace Command.eshop
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
