using System.Collections.Generic;

namespace ProgPart3
{
    public static class CybersecurityQuestions
    {
        public static List<(string Question, List<string> Options, int CorrectIndex, string Explanation)> GetQuizQuestions()
        {
            return new List<(string, List<string>, int, string)>
            {
                ("What should you do if you receive an email asking for your password?",
                    new List<string> { "Reply with your password", "Delete the email", "Report the email as phishing", "Ignore it" }, 2,
                    "Correct! Reporting phishing emails helps prevent scams."),

                ("How can you recognize a phishing email?",
                    new List<string> { "It has no subject", "It comes from a known address", "It asks for personal info urgently", "It has perfect grammar" }, 2,
                    "Correct! Phishing emails often ask for sensitive info urgently."),

                ("What does a phishing email often include?",
                    new List<string> { "Strange links", "Personal greetings", "No spelling mistakes", "Encrypted attachments" }, 0,
                    "Correct! Strange or misleading links are common in phishing emails."),

                ("True or False: Using '123456' as your password is safe.",
                    new List<string> { "True", "False" }, 1,
                    "Correct! That’s a very weak password."),

                ("Which of the following is a sign of phishing?",
                    new List<string> { "Unexpected attachments", "Grammatical errors", "Urgent requests", "All of the above" }, 3,
                    "Correct! Phishing emails often have all of these signs."),

                ("What is two-factor authentication?",
                    new List<string> { "A way to reset passwords", "An extra layer of security", "A firewall rule", "A virus scanner" }, 1,
                    "Correct! 2FA adds another security step."),

                ("Which one protects your data during internet use?",
                    new List<string> { "VPN", "Incognito mode", "Cookies", "Auto-fill" }, 0,
                    "Correct! VPNs encrypt your data."),

                ("True or False: Updating software regularly is unnecessary.",
                    new List<string> { "True", "False" }, 1,
                    "Correct! Updates fix security issues."),

                ("Which of these is a strong password?",
                    new List<string> { "kiara123", "pass123", "P@ssw0rd!", "123456" }, 2,
                    "Correct! It uses a mix of characters."),

                ("Which is NOT a cybersecurity best practice?",
                    new List<string> { "Sharing your password", "Using 2FA", "Installing antivirus", "Regular updates" }, 0,
                    "Correct! Never share passwords."),

                ("What's a good way to avoid malware?",
                    new List<string> { "Click all links", "Download random files", "Use antivirus software", "Ignore software updates" }, 2,
                    "Correct! Antivirus helps catch malware."),

                ("What should you do if you suspect a data breach?",
                    new List<string> { "Ignore it", "Change passwords", "Tell no one", "Keep using same password" }, 1,
                    "Correct! Always change your passwords immediately."),

                ("Which of the following is a type of malware?",
                    new List<string> { "Phishing", "Firewall", "Ransomware", "Encryption" }, 2,
                    "Correct! Ransomware is a type of malware."),

                ("Why is public Wi-Fi risky?",
                    new List<string> { "It's free", "It has stronger signals", "It can expose your data", "It's slower" }, 2,
                    "Correct! Hackers can intercept your information on public Wi-Fi."),

                ("True or False: Clicking unknown links in emails is safe if they look legitimate.",
                    new List<string> { "True", "False" }, 1,
                    "Correct! Always be cautious of unknown links."),

                ("What does a firewall do?",
                    new List<string> { "Cools down your device", "Filters network traffic", "Stores backups", "Manages passwords" }, 1,
                    "Correct! Firewalls block unauthorized access."),

                ("Which is an example of a strong authentication method?",
                    new List<string> { "Username only", "Password only", "Password + OTP", "Name and birthday" }, 2,
                    "Correct! Multi-factor authentication is stronger."),

                ("Which of these is a social engineering tactic?",
                    new List<string> { "Brute force", "Tailgating", "Firewall", "Encryption" }, 1,
                    "Correct! Tailgating is a physical form of social engineering."),

                ("Why should you backup data regularly?",
                    new List<string> { "To free up space", "To prevent data loss", "To speed up your device", "To hide it" }, 1,
                    "Correct! Backups help recover data after breaches or crashes."),

                ("True or False: Using the same password for all accounts is okay.",
                    new List<string> { "True", "False" }, 1,
                    "Correct! Each account should have a unique password."),

                ("What is encryption used for?",
                    new List<string> { "Speeding up internet", "Securing data", "Improving graphics", "Blocking ads" }, 1,
                    "Correct! Encryption keeps your data safe from unauthorized access.")
            };
        }

        public static readonly Dictionary<int, string> TopicNumberToKey = new()
        {
            {1, "cybersecurity"},
            {2, "backup"},
            {3, "phishing"},
            {4, "ransomware"},
            {5, "malware"},
            {6, "encryption"},
            {7, "firewalls"},
            {8, "twofactorauthentication"},
            {9, "passwordsafety"},
            {10, "passwordsecurity"},
            {11, "socialengineering"},
            {12, "safebrowsing"},
            {13, "wifisecurity"},
            {14, "softwareupdates"},
            {15, "incidentresponses"},
            {16, "physicalsecurity"},
            {17, "insiderthreats"},
            {18, "cloudsecurity"},
            {19, "mobilesecurity"},
            {20, "emailsecurity"}
        };

        public static readonly HashSet<string> TopicKeys = new(TopicNumberToKey.Values);

        public static string GetTopicByNumber(int num)
        {
            return TopicNumberToKey.TryGetValue(num, out string key) ? key : null;
        }
    }
}
