using Invoking_Javascript_Function.Client.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoking_Javascript_Function.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = new List<Data>()
            {
                new Data(){Id=101,Name="Aman", Address="Noida"}
            };
        }
    private  async Task Delete(Data D1)
        {
            await js.InvokeVoidAsync("my_function", message);
            var confirmed = await js.Confirm( $"Are You Sure Want to Delete Record{D1.Id}{D1.Name} {D1.Address}");
            d.Remove(D1);
           
        }
        private void Add(Data D2)
        {
            d.Add(D2);
        }
        public bool check = false;
        private object[] message;
    }



}
