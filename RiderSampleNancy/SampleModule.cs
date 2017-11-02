
using System;
using Nancy;

namespace RiderSampleNancy
{
    public class SampleModule : Nancy.NancyModule
    {
        private struct counterObj
        {
            public int callCount = 0;
        }
        
        private counterObj pp = new counterObj();
        
        public SampleModule()
        {
            
            
            Get["/"] = arg => "Hello World!"; //This works; passing data is not so successful.
            //Get("/", arg => string.Format("Hello world! {0}", pp.callCount++));
            //Get("/", arg => string.Format("Hello world! {0}", arg++));
        }

    }
}