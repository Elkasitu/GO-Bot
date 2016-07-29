﻿using System;
using System.IO;

namespace GO_Bot.Internals {

	internal static class ApplicationEnvironment {

		static ApplicationEnvironment() {
			EnsureExists(SettingsDirectory());
			EnsureExists(LogsDirectory());
		}

		public static void EnsureExists(string directoryPath) {
			Directory.CreateDirectory(directoryPath);
		}

		public static string AppData() {
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}

		public static string MainDirectory() {
			return AppData() + "\\GO Bot";
		}

		public static string SettingsDirectory() {
			return MainDirectory() + "\\Settings";
		}

		public static string LogsDirectory() {
			return MainDirectory() + "\\Logs";
		}
		
	}

}
