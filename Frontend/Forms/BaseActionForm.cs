using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Core;

namespace Frontend.Forms
{
    public partial class BaseActionForm : BaseForm
    {
        public enum CloseResult
        {
            Cancel,
            Submit    
        }

        //public delegate void ClosingActionFormDelegate(CloseResult closeResult);

        //public event ClosingActionFormDelegate RaiseClosingActionForm;
        
        public BaseActionForm()
        {
            InitializeComponent();
        }
        public BaseActionForm(IController controller) : base(controller)
        {
            InitializeComponent();

        }
       
    }
}
