using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cviceni12_webAPI.Models;

namespace Cviceni12_webAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public decimal Post([FromBody] CalcData calcData)
        {
            switch (calcData.Operace)
            {
                case "plus":
                    return calcData.Operand1 + calcData.Operand2;
                case "minus":
                    return calcData.Operand1 - calcData.Operand2;
                case "krat":
                    return calcData.Operand1 * calcData.Operand2;
                case "deleno":
                    return calcData.Operand1 / calcData.Operand2;
                default:
                    throw new ArgumentException("Neplatna operace");
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
