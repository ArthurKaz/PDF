using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.PDFCreats;
using System;

namespace PDFOfferCreator.Web.Pages
{
	public class PDFDownloaderBase : ComponentBase
	{
		[Inject]
		public IJSRuntime JS {  get; set; }


        [Parameter]
		public OfferData OfferData { get; set; }

		public bool ReadyToDownload { get; set; } = false;

		private HTMLFiller pDFFiller;

		private void Test()
		{
			ReadyToDownload = true;
		}

		protected override async Task OnInitializedAsync()
		{
			//pDFFiller = new HTMLFiller(JS);
		//	var replace = await pDFFiller.FillData(OfferData);
			/*if (replace)
			{
				ReadyToDownload = true;
				pDFFiller.FileDownloaded += Test;
			}*/
		}
		public async Task Download()
		{
            ReadyToDownload = false;
			await pDFFiller.Download();
		}
    }
}
