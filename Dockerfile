# ===============================
# Stage 1: Build
# ===============================
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# انسخ كل الملفات (solution + projects + props/targets)
COPY . .

# Restore للسوليوشن
RUN dotnet restore "Dev.Acadmy.sln"

# Build + Publish لمشروع الـ Host
WORKDIR /src/src/Dev.Acadmy.HttpApi.Host
RUN dotnet publish "Dev.Acadmy.HttpApi.Host.csproj" -c Release -o /app/publish

# ===============================
# Stage 2: Runtime
# ===============================
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

# انسخ ملفات النشر فقط
COPY --from=build /app/publish .

# انسخ ملفات الإعدادات الخاصة بالبيئة Production
COPY src/Dev.Acadmy.HttpApi.Host/appsettings*.json .

# انسخ ملف الشهادة داخل الحاوية
COPY src/Dev.Acadmy.HttpApi.Host/openiddict.pfx /app/openiddict.pfx

# ===============================
# الإضافات المطلوبة (بس)
# ===============================

# خلي Kestrel يسمع على كل الشبكات
ENV ASPNETCORE_URLS=http://+:8080

# تعريف البورت للمنصة
EXPOSE 8080

# ===============================
# متغيرات البيئة (زي ما هي)
# ===============================
ENV OPENIDDICT_CERT_PATH=/app/openiddict.pfx
ENV OPENIDDICT_CERT_PASSWORD=010203
ENV ASPNETCORE_ENVIRONMENT=Production

# تأكد من وجود مجلد Logs للـ Serilog
RUN mkdir -p /app/Logs

# ENTRYPOINT لتشغيل الـ Host
ENTRYPOINT ["dotnet", "Dev.Acadmy.HttpApi.Host.dll"]
