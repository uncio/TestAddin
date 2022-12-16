using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic.Services
{
    internal class GenericEventHandler : IExternalEventHandler
    {
        protected Action<UIApplication> Action;

        public virtual void Execute(UIApplication app)
        {
            Action?.Invoke(app);
        }

        public string GetName()
        {
            return GetType().Name;
        }

        internal void SetAction(Action<UIApplication> action)
        {
            Action = action;
        }
    }
}
