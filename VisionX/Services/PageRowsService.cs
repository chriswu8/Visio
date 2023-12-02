using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionX.Services
{

    public interface IPageRowsService
    {
        bool RowClicked { get; set; }
        event EventHandler RowClickedChanged;
    }

    public class PageRowsService : IPageRowsService
    {
        private bool _rowClicked;

        public bool RowClicked
        {
            get => _rowClicked;
            set
            {
                _rowClicked = value;
                OnRowClickedChanged();
            }
        }

        public event EventHandler RowClickedChanged;

        protected virtual void OnRowClickedChanged()
        {
            RowClickedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}