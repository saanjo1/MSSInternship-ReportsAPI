using ReportsAPI.Contracts;
using Azure.Data.Tables;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.AspNetCore.Mvc;
using ReportsAPI.Models;
using AutoMapper;
using Azure;

namespace ReportsAPI.Services
{
    public class IotDevicesReportsRepository : IRepository<IotDevice>
    {

        private string _connectionString;
        private string _tableName;
        private TableServiceClient _tableServiceClient;



        public IotDevicesReportsRepository(string connectionString, string tableName)
        {

            _connectionString = connectionString ?? throw new ArgumentNullException("connectionString", "connectionString is null");
            _tableName = tableName ?? throw new ArgumentNullException("tablePrefix", "tablePrefix is null.");
            _tableServiceClient = new TableServiceClient(_connectionString);
        }

        public async Task<int> CountAsync()
        {
            AsyncPageable<IotDeviceTableEntity> query = _tableServiceClient.GetTableClient(_tableName).QueryAsync<IotDeviceTableEntity>();

            List<IotDeviceTableEntity> entities = new List<IotDeviceTableEntity>();

            await foreach (IotDeviceTableEntity item in query)
            {
                entities.Add(item);
            }

            return entities.Count();
        }
    }
}
