using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    public interface IPageService
    {
        Task PushAsnyc(Page page);
    }
}
