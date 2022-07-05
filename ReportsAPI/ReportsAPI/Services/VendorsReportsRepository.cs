using ReportsAPI.Contracts;
using Azure.Data.Tables;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.AspNetCore.Mvc;
using ReportsAPI.Models;
using AutoMapper;

namespace ReportsAPI.Services
{
    public class VendorsReportsRepository : IRepository<Vendor>
    {

        private string _connectionString;
        private string _tableName;
        private CloudTableClient _tableClient;
        private CloudTable _table;
        private readonly IMapper _mapper;


        public VendorsReportsRepository(string connectionString, string tableName, IMapper mapper)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException("connectionString is null");
            _tableName = tableName ?? throw new ArgumentNullException("tableName is null");
            CloudStorageAccount storageAccount =
              CloudStorageAccount.Parse(connectionString);
            _tableClient = storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference(tableName);
            _table.CreateIfNotExists();
            _mapper = mapper;
        }

        public async Task<int> CountAsync()
        {
            var query = new TableQuery<VendorTableEntity>();
            var lst = _table.ExecuteQuery(query);
            var result = lst.Select(x => _mapper.Map<Vendor>(x));

            return result.Count();
        }

      
    }
}
