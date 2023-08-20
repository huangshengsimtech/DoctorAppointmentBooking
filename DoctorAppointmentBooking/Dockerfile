#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DoctorAppointmentBooking/DoctorAppointmentBooking.Bootstrapper.csproj", "DoctorAppointmentBooking/"]
COPY ["Authentication.API/Authentication.API.csproj", "Authentication.API/"]
COPY ["SharedKernel.Infrastructure/SharedKernel.Infrastructure.csproj", "SharedKernel.Infrastructure/"]
COPY ["Booking.API/ManagementInquiry.API.csproj", "Booking.API/"]
COPY ["Booking.Application/ManagementInquiry.Application.csproj", "Booking.Application/"]
COPY ["Management.Shared/Management.Shared.csproj", "Management.Shared/"]
COPY ["Management.Domain/Management.Domain.csproj", "Management.Domain/"]
COPY ["DoctorAppointmentBookingLayered/DoctorAppointmentBookingLayered.csproj", "DoctorAppointmentBookingLayered/"]
COPY ["Management.API/Management.API.csproj", "Management.API/"]
COPY ["Management.Application/Management.Application.csproj", "Management.Application/"]
COPY ["Management.Infrastructure/Management.Infrastructure.csproj", "Management.Infrastructure/"]
COPY ["Notification.API/Notification.API.csproj", "Notification.API/"]
COPY ["Notification.Application/Notification.Application.csproj", "Notification.Application/"]
COPY ["Notification.Domain/Notification.Domain.csproj", "Notification.Domain/"]
COPY ["Shared.Core/Shared.Core.csproj", "Shared.Core/"]
COPY ["Notification.Infrastructure/Notification.Infrastructure.csproj", "Notification.Infrastructure/"]
COPY ["Notification.Shared/Notification.Shared.csproj", "Notification.Shared/"]
COPY ["PatientBooking/Booking.csproj", "PatientBooking/"]
RUN dotnet restore "DoctorAppointmentBooking/DoctorAppointmentBooking.Bootstrapper.csproj"
COPY . .
WORKDIR "/src/DoctorAppointmentBooking"
RUN dotnet build "DoctorAppointmentBooking.Bootstrapper.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DoctorAppointmentBooking.Bootstrapper.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DoctorAppointmentBooking.Bootstrapper.dll"]