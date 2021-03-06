﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Tests.TestDb
{
    class TestControllerContext : ControllerContext
    {
        HttpContextBase _context = new TestHttpContext();

        public override System.Web.HttpContextBase HttpContext
        {
            get { return _context; }
            set { _context = value; }
        }
    }

    class TestHttpContext : HttpContextBase
    {
        HttpRequestBase _request = new TestHttpRequest();

        public override HttpRequestBase Request
        {
            get
            {
                return _request;
            }
        }
    }

    class TestHttpRequest : HttpRequestBase
    {
        public override string this[string key]
        {
            get
            {
                return null;
            }
        }

        public override NameValueCollection Headers
        {
            get
            {
                return new NameValueCollection();
            }
        }
    }
}
