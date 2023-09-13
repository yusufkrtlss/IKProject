using IKProject.BusinessLayer.Abstract;
using IKProject.BusinessLayer.Concrete;
using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Concrete;
using IKProject.DataAccessLayer.EntityFramework;
using IKProject.DataAccessLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StoreContext>(); // Db Context

// Scoped
builder.Services.AddScoped(typeof(IGenericDal<>),typeof(GenericRepository<>));

builder.Services.AddScoped<IApplicationDal, EFApplicationDal>();
builder.Services.AddScoped<IApplicationService, ApplicationManager>();

builder.Services.AddScoped<ICommentDal, EFCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<IDepartmentDal, EFDepartmentDal>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();

builder.Services.AddScoped<IGenderDal, EFGenderDal>();
builder.Services.AddScoped<IGenderService, GenderManager>();

builder.Services.AddScoped<IMeetingDal, EFMeetingDal>();
builder.Services.AddScoped<IMeetingService, MeetingManager>();

builder.Services.AddScoped<IStaffDal, EFStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<IStaffMeetingDal, EFStaffMeetingDal>();
builder.Services.AddScoped<IStaffMeetingService, StaffMeetingManager>();


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
