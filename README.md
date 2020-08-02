[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=prachwal_app&metric=alert_status)](https://sonarcloud.io/dashboard?id=prachwal_app)
![.NET Core](https://github.com/prachwal/app/workflows/.NET%20Core/badge.svg)
# app

Przykładowa aplikacja do robienia niczego pożytecznego

konfiguracja usługi /etc/supervisor/conf.d/hellomvc.conf

sudo dotnet publish -c Release --self-contained -r ubuntu.18.04-x64 -o /var/aspnetcore/HelloMVC/

[program:hellomvc]
command=/usr/bin/dotnet /var/aspnetcore/HelloMVC/api.dll
directory=/var/aspnetcore/HelloMVC/
autostart=true
autorestart=true
stderr_logfile=/var/log/hellomvc.err.log
stdout_logfile=/var/log/hellomvc.out.log
environment=ASPNETCORE_ENVIRONMENT=Production
user=prachwal
stopsignal=INT

sudo service supervisor stop
sudo service supervisor start

sudo tail -f /var/log/supervisor/supervisord.log