using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionX.Services
{
    public interface IPatientRowsService
    {
        bool PatientRowSelected { get; set; }
        event EventHandler PatientRowSelectedChanged;
    }

    public class PatientRowsService : IPatientRowsService
    {
        private bool _patientRowSelected;

        public bool PatientRowSelected
        {
            get => _patientRowSelected;
            set
            {
                _patientRowSelected = value;
                OnPatientRowSelectedChanged();
            }
        }

        public event EventHandler PatientRowSelectedChanged;

        protected virtual void OnPatientRowSelectedChanged()
        {
            PatientRowSelectedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}