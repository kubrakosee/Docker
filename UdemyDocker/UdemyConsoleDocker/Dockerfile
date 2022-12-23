##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
#WORKDIR /app
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
#WORKDIR /src
#COPY ["UdemyConsoleDocker/UdemyConsoleDocker.csproj", "UdemyConsoleDocker/"]
#RUN dotnet restore "UdemyConsoleDocker/UdemyConsoleDocker.csproj"
#COPY . .
#WORKDIR "/src/UdemyConsoleDocker"
#RUN dotnet build "UdemyConsoleDocker.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "UdemyConsoleDocker.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "UdemyConsoleDocker.dll"] içerisindeki siliyoruz
#benim ilk yapmam gereken þu benim bir iþletim sistemi lazým
#ama nasýl bir iþletim sistemi lazým iþetim sisteminden kasttým image lazým baan
#öyle bir image olmasý gerekiyor ki içerisinde mini bir
#linux iþletim sistemi onun üzerine benim asp.net core uygulamamýn console uygulamamý çalýþtýracak
#gerekli kütüphaneleri bulunduðu bir linux iþletim sistemi lazým
#ben bunu kendim yazmayacaðým microsoftun docker hub tarafýnda resmi olarak yayýnladýðý imageler vardý gelin
#onlardan birini  kullanalým.benim sdk yý yapmama gerek yok çünkü ben publish olaný vericem 
#bu yüzden ben runtime ý yapmam gerekicek.Þimdi Docker Hub a gel
#.net core runtime de arama yerine yaz.From komutunun yaptýðý docker hubdan
#image almanýzý saðlar.Ýmage yüklemenizi saðlar

FROM mcr.microsoft.com/dotnet/runtime:3.1
#image içerisinde bir dosya oluþturacak bir komut yazdýracaðým
#imagelar katmanlardan oluþuyordu benim ilk yazdýðým kodda katmaný 1 taensini
#oluþturdu bir klasör oluþturayým projeyi onun içine atayým 
#WORKDIR çalýþma klasörü oluþuyor app klasöründe çalýþaðýmý belli ediyorum
WORKDIR /App

#benim arkasýndan bu app klasörün içerisine benim console uygulamamým
#publish edilmiþ datasýný atacaðým 

COPY bin/Release/netcoreapp3.1/publish app/ 

#peki ben bunu nereye copyalayacaðým app klasörü kopyala diyorum

#ENTRYPOINT bir image dan bir container ayaða kalktýðý zaman çalýþýcak olan 
#kodu belli edeceðim docker bunu kendi içinde çalýþtýracaðý için dll yi veriyorum.Baðýmsýz olarak çalýþtýrmak istiyorsanýz exe yi çalýþtýrýrsýnýz

ENTRYPOINT ["dotnet","UdemyConsoleDocker.dll"]

#ilgili image dan bir container ayaða kalktýðý zaman benim entrypointte deki kaldýrýlacak






