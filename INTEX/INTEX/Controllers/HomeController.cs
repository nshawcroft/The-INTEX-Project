using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CustomerOrderInformation()
        {
            return View();
        }

        public ActionResult OrderSummary()
        {
            return View();
        }

        public ActionResult OrderSubmitted()
        {
            return View();
        }

        public ActionResult OrderPackingSlip()
        {
            return View();
        }

        public ActionResult ReviewOrder()
        {
            return View();
        }

        public ActionResult CustomerCurrentOrderDetails()
        {
            return View();
        }

        public ActionResult CustomerOldOrders()
        {
            return View();
        }

        public ActionResult CustomerOldOrderDetails()
        {
            return View();
        }

        public ActionResult ProfitabilityReport()
        {
            return View();
        }

        public ActionResult ViewAssay()
        {
            return View();
        }

        public ActionResult AddAssay()
        {
            return View();
        }

        public ActionResult AddTestToAssay()
        {
            return View();
        }

        public ActionResult ApproveWorkOrders()
        {
            return View();
        }

        public ActionResult ApproveWorkOrderDetails()
        {
            return View();
        }

        public ActionResult ScheduleTest()
        {
            return View();
        }

        public ActionResult CreateCustomer()
        {
            return View();
        }

        public ActionResult CreateCustomerConfirmation()
        {
            return View();
        }

        public ActionResult PreScanOrder()
        {
            return View();
        }

        public ActionResult ScanOrderDetails()
        {
            return View();
        }

        public ActionResult ScanOrderCompound()
        {
            return View();
        }

        public ActionResult ScanOrderSummary()
        {
            return View();
        }

        public ActionResult ScanOrderDetailsDiscrepency()
        {
            return View();
        }

        public ActionResult ScanOrderResolve()
        {
            return View();
        }

        public ActionResult ScanOrderCount()
        {
            return View();
        }

        public ActionResult SearchCustomer()
        {
            return View();
        }

        public ActionResult CustomerDetails()
        {
            return View();
        }

        public ActionResult ViewTests()
        {
            return View();
        }

        public ActionResult EditTest()
        {
            return View();
        }

        public ActionResult Invoices()
        {
            return View();
        }

        public ActionResult InvoiceDetails()
        {
            return View();
        }
    }
}