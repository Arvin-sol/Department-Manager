
using Department.Application.Commands.CommandsHandlers;
using Department.Application.Commands;
using Department.Application.Common.Interfaces;
using Department.Application.DTOs;
using Department.Application.Queries.QueriesHandlers;
using Department.Application.Queries;
using Department.Persistance.UnitOfWork;
using Department_managment.Persistance.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Department.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            #region Confige Database
            builder.Services.AddDbContext<ApplicationDbContext>(
                                x => x.UseSqlServer(
                                        builder.Configuration.GetConnectionString("DefualtConnection")));
            #endregion

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

            #region Service Config
            builder.Services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            builder.Services.AddScoped<IRequestHandler<GetDepartmentWithEmployeesQuery, DepartmentWithEmployeeListDTO>, GetDepartmentWithEmployeesQueryHandler>();
            builder.Services.AddScoped<IRequestHandler<CreateDepartmentCommand, bool>, CreateDepartmentCommandHandler>();
            builder.Services.AddScoped<IRequestHandler<CreateEmployeeCommand, bool>, CreateEmployeeCommandHandler>();
            builder.Services.AddScoped<IRequestHandler<UpdatingDepartmentCommand, bool>, UpdatingDepartmentCommandHandler>();

            #endregion 



            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}