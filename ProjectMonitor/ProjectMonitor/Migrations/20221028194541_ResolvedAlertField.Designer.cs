﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectMonitor.Api.Database.Context;

#nullable disable

namespace ProjectMonitor.Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221028194541_ResolvedAlertField")]
    partial class ResolvedAlertField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.BreganTwitchBot", b =>
                {
                    b.Property<string>("Mode")
                        .HasColumnType("text")
                        .HasColumnName("mode");

                    b.Property<bool>("DailyPointsEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("dailyPointsEnabled");

                    b.Property<bool>("DiscordConnectionStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("discordConnectionStatus");

                    b.Property<DateTime>("LastDiscordLeaderboardsUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastDiscordLeaderboardsUpdate");

                    b.Property<DateTime>("LastHoursUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastHoursUpdate");

                    b.Property<bool>("StreamAnnounced")
                        .HasColumnType("boolean")
                        .HasColumnName("streamAnnounced");

                    b.Property<DateTime>("StreamLiveTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("streamLiveTime");

                    b.Property<bool>("StreamStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("streamStatus");

                    b.Property<TimeSpan>("StreamUptime")
                        .HasColumnType("interval")
                        .HasColumnName("streamUptime");

                    b.Property<DateTime>("TwitchApiKeyLastRefreshTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("twitchApiKeyLastRefreshTime");

                    b.Property<bool>("TwitchIRCConnectionStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("twitchIRCConnectionStatus");

                    b.Property<bool>("TwitchPubSubConnectionStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("twitchPubSubConnectionStatus");

                    b.Property<long>("UsersInStream")
                        .HasColumnType("bigint")
                        .HasColumnName("usersInStream");

                    b.HasKey("Mode");

                    b.ToTable("BreganTwitchBot");

                    b.HasData(
                        new
                        {
                            Mode = "debug",
                            DailyPointsEnabled = false,
                            DiscordConnectionStatus = true,
                            LastDiscordLeaderboardsUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastHoursUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            StreamAnnounced = false,
                            StreamLiveTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            StreamStatus = false,
                            StreamUptime = new TimeSpan(0, 0, 0, 0, 0),
                            TwitchApiKeyLastRefreshTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            TwitchIRCConnectionStatus = true,
                            TwitchPubSubConnectionStatus = true,
                            UsersInStream = 0L
                        },
                        new
                        {
                            Mode = "release",
                            DailyPointsEnabled = false,
                            DiscordConnectionStatus = true,
                            LastDiscordLeaderboardsUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastHoursUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            StreamAnnounced = false,
                            StreamLiveTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            StreamStatus = false,
                            StreamUptime = new TimeSpan(0, 0, 0, 0, 0),
                            TwitchApiKeyLastRefreshTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            TwitchIRCConnectionStatus = true,
                            TwitchPubSubConnectionStatus = true,
                            UsersInStream = 0L
                        });
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.CatBot", b =>
                {
                    b.Property<string>("Mode")
                        .HasColumnType("text")
                        .HasColumnName("mode");

                    b.Property<bool>("DiscordConnectionStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("discordConnectionStatus");

                    b.Property<DateTime>("LastDiscordPost")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastDiscordPost");

                    b.Property<DateTime>("LastTweet")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastTweet");

                    b.HasKey("Mode");

                    b.ToTable("CatBot");

                    b.HasData(
                        new
                        {
                            Mode = "debug",
                            DiscordConnectionStatus = true,
                            LastDiscordPost = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastTweet = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Mode = "release",
                            DiscordConnectionStatus = true,
                            LastDiscordPost = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastTweet = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.Errors", b =>
                {
                    b.Property<int>("ErrorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("errorId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ErrorId"));

                    b.Property<bool>("AlertSent")
                        .HasColumnType("boolean")
                        .HasColumnName("alertSent");

                    b.Property<DateTime?>("DateEnded")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dateEnded");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dateStarted");

                    b.Property<TimeSpan>("DowntimeDuration")
                        .HasColumnType("interval")
                        .HasColumnName("downtimeDuration");

                    b.Property<string>("ErrorDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("errorDescription");

                    b.Property<string>("ErrorType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("errorType");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("projectName");

                    b.Property<bool>("ResolvedAlertSent")
                        .HasColumnType("boolean")
                        .HasColumnName("resolvedAlertSent");

                    b.HasKey("ErrorId");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.FinanceManager", b =>
                {
                    b.Property<string>("Mode")
                        .HasColumnType("text")
                        .HasColumnName("mode");

                    b.Property<DateTime>("LastAPIRefresh")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastAPIRefresh");

                    b.Property<string>("LastAPIRefreshStatusCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastAPIRefreshStatusCode");

                    b.Property<DateTime>("LastTransactionUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastTransactionUpdate");

                    b.HasKey("Mode");

                    b.ToTable("FinanceManager");

                    b.HasData(
                        new
                        {
                            Mode = "debug",
                            LastAPIRefresh = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastAPIRefreshStatusCode = "Success",
                            LastTransactionUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Mode = "release",
                            LastAPIRefresh = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastAPIRefreshStatusCode = "Success",
                            LastTransactionUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.ProjectHealth", b =>
                {
                    b.Property<string>("ProjectName")
                        .HasColumnType("text")
                        .HasColumnName("projectName");

                    b.Property<double>("CPUUsage")
                        .HasColumnType("double precision")
                        .HasColumnName("cpuUsage");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastUpdate");

                    b.Property<bool>("ProjectRunning")
                        .HasColumnType("boolean")
                        .HasColumnName("projectRunning");

                    b.Property<TimeSpan>("ProjectUptime")
                        .HasColumnType("interval")
                        .HasColumnName("projectUptime");

                    b.Property<long>("RAMUsage")
                        .HasColumnType("bigint")
                        .HasColumnName("ramUsage");

                    b.HasKey("ProjectName");

                    b.ToTable("ProjectHealth");
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.RetroAchievementsTracker", b =>
                {
                    b.Property<string>("Mode")
                        .HasColumnType("text")
                        .HasColumnName("mode");

                    b.Property<long>("GamesUpdated")
                        .HasColumnType("bigint")
                        .HasColumnName("gamesUpdated");

                    b.Property<DateTime>("LastGameUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastGameUpdate");

                    b.Property<long>("TotalGames")
                        .HasColumnType("bigint")
                        .HasColumnName("totalGames");

                    b.Property<long>("TotalUsers")
                        .HasColumnType("bigint")
                        .HasColumnName("totalUsers");

                    b.HasKey("Mode");

                    b.ToTable("RetroAchievementsTracker");

                    b.HasData(
                        new
                        {
                            Mode = "debug",
                            GamesUpdated = 0L,
                            LastGameUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            TotalGames = 0L,
                            TotalUsers = 0L
                        },
                        new
                        {
                            Mode = "release",
                            GamesUpdated = 0L,
                            LastGameUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            TotalGames = 0L,
                            TotalUsers = 0L
                        });
                });

            modelBuilder.Entity("ProjectMonitor.Api.Database.Models.SystemHealth", b =>
                {
                    b.Property<string>("SystemName")
                        .HasColumnType("text")
                        .HasColumnName("systemName");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lastUpdate");

                    b.Property<TimeSpan>("SystemUptime")
                        .HasColumnType("interval")
                        .HasColumnName("systemUptime");

                    b.HasKey("SystemName");

                    b.ToTable("SystemHealth");
                });
#pragma warning restore 612, 618
        }
    }
}
