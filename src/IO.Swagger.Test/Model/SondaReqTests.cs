/* 
 * Sonda Saque e Pague
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SondaReq
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SondaReqTests
    {
        // TODO uncomment below to declare an instance variable for SondaReq
        //private SondaReq instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SondaReq
            //instance = new SondaReq();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SondaReq
        /// </summary>
        [Test]
        public void SondaReqInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SondaReq
            //Assert.IsInstanceOfType<SondaReq> (instance, "variable 'instance' is a SondaReq");
        }


        /// <summary>
        /// Test the property 'InfTransacao'
        /// </summary>
        [Test]
        public void InfTransacaoTest()
        {
            // TODO unit test for the property 'InfTransacao'
        }
        /// <summary>
        /// Test the property 'Terminal'
        /// </summary>
        [Test]
        public void TerminalTest()
        {
            // TODO unit test for the property 'Terminal'
        }

    }

}
