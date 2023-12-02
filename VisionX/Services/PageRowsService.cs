using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionX.Services
{

    public interface IPageRowsService
    {
        bool RowClicked { get; set; }
        bool SelectedRowEmpty { get; set; }

        event EventHandler RowClickedChanged;
    }

    public class PageRowsService : IPageRowsService
    {
        private bool _rowClicked;
        private bool _selectedRowEmpty;


        public bool RowClicked
        {
            get => _rowClicked;
            set
            {
                _rowClicked = value;
                OnRowClickedChanged();
            }
        }

        // public bool SelectedRowEmpty
        // {
        //     get => _selectedRowEmpty;
        //     set => _selectedRowEmpty = value;
        // }


        public event EventHandler RowClickedChanged;

        protected virtual void OnRowClickedChanged()
        {
            RowClickedChanged?.Invoke(this, EventArgs.Empty);
        }

        // ========================================

        public bool SelectedRowEmpty
        {
            get => _selectedRowEmpty;
            set
            {
                _selectedRowEmpty = value;
                OnSelectedRowEmptyChanged(); // Invoke event when the value changes
            }
        }

        public event EventHandler SelectedRowEmptyChanged;

        protected virtual void OnSelectedRowEmptyChanged()
        {
            SelectedRowEmptyChanged?.Invoke(this, EventArgs.Empty);
        }

        public void SetSelectedRowEmpty(bool value)
        {
            SelectedRowEmpty = value; // Set the SelectedRowEmpty property
        }
    }
}