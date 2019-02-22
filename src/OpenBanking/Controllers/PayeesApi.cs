/*
 * Consumer Data Standards
 *
 * API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OpenBanking.Attributes;
using OpenBanking.Models;

namespace OpenBanking.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class PayeesApiController : Controller
    { 
        /// <summary>
        /// Get Payee Detail
        /// </summary>
        /// <remarks>Obtain detailed information on a single payee</remarks>
        /// <param name="payeeId">The ID used to locate the details of a particular payee</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/payees/{payeeId}")]
        [ValidateModelState]
        [SwaggerOperation("GetPayeeDetail")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingPayeeDetails), description: "Success")]
        public virtual IActionResult GetPayeeDetail([FromRoute][Required]string payeeId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingPayeeDetails));

            string exampleJson = null;
            exampleJson = "{\r\n  \"data\" : \"\",\r\n  \"meta\" : { },\r\n  \"links\" : {\r\n    \"self\" : \"self\"\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingPayeeDetails>(exampleJson)
            : default(ResponseBankingPayeeDetails);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Payees
        /// </summary>
        /// <remarks>Obtain a list of pre-registered payees</remarks>
        /// <param name="type">Filter on the payee type field.  In addition to normal type field values, ALL can be specified to retrieve all payees.  If absent the assumed value is ALL</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/payees")]
        [ValidateModelState]
        [SwaggerOperation("ListPayees")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingPayees), description: "Success")]
        public virtual IActionResult ListPayees([FromQuery]string type, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingPayees));

            string exampleJson = null;
            exampleJson = "{\r\n  \"data\" : {\r\n    \"payees\" : [ {\r\n      \"nickname\" : \"nickname\",\r\n      \"description\" : \"description\",\r\n      \"payeeId\" : \"payeeId\",\r\n      \"type\" : \"DOMESTIC\",\r\n      \"creationDate\" : \"creationDate\"\r\n    }, {\r\n      \"nickname\" : \"nickname\",\r\n      \"description\" : \"description\",\r\n      \"payeeId\" : \"payeeId\",\r\n      \"type\" : \"DOMESTIC\",\r\n      \"creationDate\" : \"creationDate\"\r\n    } ]\r\n  },\r\n  \"meta\" : {\r\n    \"totalRecords\" : 0,\r\n    \"totalPages\" : 6\r\n  },\r\n  \"links\" : {\r\n    \"next\" : \"next\",\r\n    \"last\" : \"last\",\r\n    \"prev\" : \"prev\",\r\n    \"self\" : \"self\",\r\n    \"first\" : \"first\"\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingPayees>(exampleJson)
            : default(ResponseBankingPayees);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}