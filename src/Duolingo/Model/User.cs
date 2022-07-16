#region Imports

using NJJPA = Newtonsoft.Json.JsonPropertyAttribute;
using SCG = System.Collections.Generic;
using SCGLO = System.Collections.Generic.List<object>;
using SCGLS = System.Collections.Generic.List<string>;
using SDT = System.DateTime;

#endregion

namespace Duolingo.Model
{
    #region User

    /// <summary>
    /// Model user class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public class LevelTest
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("index")]
            public int Index { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("attempts")]
            public int Attempts { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("completed")]
            public bool Completed { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level")]
            public int Level { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Notifications
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("chrome_app_ad")]
            public bool ChromeAppAd { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("net_promoter")]
            public bool NetPromoter { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("schools_2016_07_ad")]
            public bool Schools201607Ad { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class PointsData
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("languages")]
            public SCGLO Languages { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("total")]
            public int Total { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class PointsRankingData
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("username")]
            public string Username { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_string")]
            public string LanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("points_data")]
            public User.PointsData PointsData { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("avatar")]
            public string Avatar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language")]
            public string Language { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("fullname")]
            public string Fullname { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("id")]
            public int Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("rank")]
            public int Rank { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("self")]
            public bool Self { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Calendar
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_id")]
            public string SkillId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("improvement")]
            public int Improvement { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("event_type")]
            public string EventType { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("datetime")]
            public object Datetime { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class TrackingProperties
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("direction")]
            public string Direction { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("took_placementtest")]
            public bool TookPlacementtest { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language")]
            public string LearningLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("utc_offset")]
            public double UtcOffset { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("unsafe_lexeme_restriction")]
            public bool UnsafeLexemeRestriction { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("ui_language")]
            public string UiLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_tree_level")]
            public int MaxTreeLevel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("streak")]
            public int Streak { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("username")]
            public string Username { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("creation_age")]
            public long CreationAge { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_observer")]
            public bool HasObserver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_picture")]
            public bool HasPicture { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_age_restricted")]
            public bool IsAgeRestricted { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("acquisition_last_landing_page")]
            public string AcquisitionLastLandingPage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("acquisition_survey_reason")]
            public string AcquisitionSurveyReason { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("premium_had_previous_item")]
            public bool PremiumHadPreviousItem { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("creation_date")]
            public SDT CreationDate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_followers")]
            public int NumFollowers { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_pearson_user")]
            public bool IsPearsonUser { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("placement_section_index")]
            public object PlacementSectionIndex { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_wechat_enabled")]
            public bool NotificationWechatEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_weekend_amulet")]
            public bool HasItemWeekendAmulet { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_clubs")]
            public bool DisableClubs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("gems")]
            public int Gems { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_fullname")]
            public bool HasFullname { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("beta_shake_to_report_enabled")]
            public object BetaShakeToReportEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("goal")]
            public int Goal { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_personalized_ads")]
            public bool DisablePersonalizedAds { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_rupee_wager")]
            public bool HasItemRupeeWager { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_events")]
            public bool DisableEvents { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_discussions")]
            public bool DisableDiscussions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_third_party_tracking")]
            public bool DisableThirdPartyTracking { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_streak_repair")]
            public bool HasItemStreakRepair { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("creation_date_new")]
            public SDT CreationDateNew { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_mature_words")]
            public bool DisableMatureWords { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_tree_id")]
            public string SkillTreeId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_stream")]
            public bool DisableStream { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("placement_depth")]
            public object PlacementDepth { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_streak_freeze")]
            public bool HasItemStreakFreeze { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_immersive_subscription")]
            public bool HasItemImmersiveSubscription { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_reason")]
            public string LearningReason { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_live_subscription")]
            public bool HasItemLiveSubscription { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_sections_unlocked")]
            public int NumSectionsUnlocked { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_classrooms")]
            public int NumClassrooms { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("creation_date_millis")]
            public long CreationDateMillis { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("beta_enrollment_status")]
            public string BetaEnrollmentStatus { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_profile_country")]
            public bool DisableProfileCountry { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("distinct_id")]
            public int DistinctId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_skills_unlocked")]
            public int NumSkillsUnlocked { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_facebook")]
            public bool HasFacebook { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_observees")]
            public int NumObservees { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("acquisition_last_landing_url")]
            public string AcquisitionLastLandingUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("achievements")]
            public SCGLS Achievements { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_whatsapp_enabled")]
            public bool NotificationWhatsappEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_premium_subscription")]
            public bool HasItemPremiumSubscription { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lingots")]
            public int Lingots { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("trial_account")]
            public bool TrialAccount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("prior_proficiency_onboarding")]
            public object PriorProficiencyOnboarding { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level")]
            public int Level { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_sms_enabled")]
            public bool NotificationSmsEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_self_observer")]
            public bool IsSelfObserver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_sessions_completed")]
            public int NumSessionsCompleted { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_item_streak_wager")]
            public bool HasItemStreakWager { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_immersion")]
            public bool DisableImmersion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("acquisition_last_landing_page_date")]
            public long AcquisitionLastLandingPageDate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("leaderboard_league")]
            public int LeaderboardLeague { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_item_streak_freeze")]
            public int NumItemStreakFreeze { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_phone_number")]
            public bool HasPhoneNumber { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_following")]
            public int NumFollowing { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_location")]
            public bool HasLocation { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class NextLesson
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lesson_number")]
            public int LessonNumber { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_title")]
            public string SkillTitle { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_url")]
            public string SkillUrl { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class SkillProgress
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level")]
            public int Level { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class CommentData
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public class Skill
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_string")]
            public string LanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("dependencies_name")]
            public SCGLS DependenciesName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("practice_recommended")]
            public bool PracticeRecommended { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disabled")]
            public bool Disabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("test_count")]
            public int TestCount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("missing_lessons")]
            public int MissingLessons { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_progress")]
            public SkillProgress SkillProgress { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lesson")]
            public bool Lesson { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_explanation")]
            public object HasExplanation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("url_title")]
            public string UrlTitle { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("icon_color")]
            public string IconColor { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("category")]
            public string Category { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_lessons")]
            public int NumLessons { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("strength")]
            public double Strength { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("beginner")]
            public bool Beginner { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("title")]
            public string Title { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_levels")]
            public int NumLevels { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("coords_y")]
            public int CoordsY { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("coords_x")]
            public int CoordsX { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("progress_level_session_index")]
            public int ProgressLevelSessionIndex { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("id")]
            public string Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_sessions_finished")]
            public int LevelSessionsFinished { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("levels_finished")]
            public int LevelsFinished { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("test")]
            public bool Test { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lesson_number")]
            public int LessonNumber { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learned")]
            public bool Learned { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_translation_nodes")]
            public int NumTranslationNodes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("achievements")]
            public SCGLO Achievements { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("description")]
            public string Description { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("index")]
            public int Index { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("bonus")]
            public bool Bonus { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("locked")]
            public bool Locked { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("explanation")]
            public string Explanation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_lexemes")]
            public int NumLexemes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_missing")]
            public int NumMissing { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("comment_data")]
            public User.CommentData CommentData { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("dependencies")]
            public SCGLS Dependencies { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("known_lexemes")]
            public SCGLS KnownLexemes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("words")]
            public SCGLS Words { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_sessions_for_level")]
            public int NumSessionsForLevel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("path")]
            public SCGLO Path { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("strength_no_disabled_no_character")]
            public double StrengthNoDisabledNoCharacter { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("strength_no_disabled")]
            public double StrengthNoDisabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("short")]
            public string Short { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("grammar")]
            public bool Grammar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("name")]
            public string Name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language")]
            public string Language { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_new_grammar")]
            public bool IsNewGrammar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("new_index")]
            public int NewIndex { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("progress_percent")]
            public double ProgressPercent { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("mastered")]
            public bool Mastered { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learned_ts")]
            public int? LearnedTs { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class PlacementTest
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("attempts")]
            public int Attempts { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class LanguageStudied
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("streak")]
            public int Streak { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_string")]
            public string LanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_progress")]
            public int LevelProgress { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("first_time")]
            public bool FirstTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("bonus_rows")]
            public SCGLO BonusRows { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("points_rank")]
            public int PointsRank { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("fluency_score")]
            public double FluencyScore { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_practice")]
            public bool PushPractice { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_section_index")]
            public int MaxSectionIndex { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_tests")]
            public SCG.List<LevelTest> LevelTests { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("direction_status")]
            public string DirectionStatus { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("next_level")]
            public int NextLevel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("linkedin_share_url")]
            public string LinkedinShareUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_practice")]
            public bool NotifyPractice { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notifications")]
            public Notifications Notifications { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_cefr_level")]
            public object MaxCefrLevel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_time")]
            public int NotifyTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("points_ranking_data")]
            public SCG.List<PointsRankingData> PointsRankingData { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_skills_learned")]
            public int NumSkillsLearned { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("calendar")]
            public SCG.List<Calendar> Calendar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("can_transliterate")]
            public bool CanTransliterate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_left")]
            public int LevelLeft { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("no_dep")]
            public bool NoDep { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tracking_properties")]
            public TrackingProperties TrackingProperties { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_strength")]
            public double LanguageStrength { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("next_lesson")]
            public NextLesson NextLesson { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_level")]
            public bool MaxLevel { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_percent")]
            public int LevelPercent { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language")]
            public string Language { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level")]
            public int Level { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skills")]
            public SCG.List<Skill> Skills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("bonus_skills")]
            public SCGLO BonusSkills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level_points")]
            public int LevelPoints { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("all_time_rank")]
            public SCGLS AllTimeRank { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("useSmartReminderTime")]
            public bool UseSmartReminderTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_depth_learned")]
            public int MaxDepthLearned { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("points")]
            public int Points { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("immersion_enabled")]
            public bool ImmersionEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("placement_test")]
            public PlacementTest PlacementTest { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("exempt_from_health")]
            public bool ExemptFromHealth { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("max_tree_level")]
            public int MaxTreeLevel { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Language
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("streak")]
            public int Streak { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_string")]
            public string LanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("points")]
            public int Points { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning")]
            public bool Learning { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language")]
            public string Abbreviation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("level")]
            public int Level { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("current_learning")]
            public bool CurrentLearning { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("sentences_translated")]
            public int SentencesTranslated { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("to_next_level")]
            public int ToNextLevel { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class LastStreak
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("shortened_product_id")]
            public string ShortenedProductId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_available_for_repair")]
            public bool IsAvailableForRepair { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("google_play_product_id")]
            public string GooglePlayProductId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("product_id")]
            public string ProductId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("days_ago")]
            public int DaysAgo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("length")]
            public int Length { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("last_reached_goal")]
            public long LastReachedGoal { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class PrivacySettings
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_clubs")]
            public bool DisableClubs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_discussions")]
            public bool DisableDiscussions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_events")]
            public bool DisableEvents { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_immersion")]
            public bool DisableImmersion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_mature_words")]
            public bool DisableMatureWords { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_personalized_ads")]
            public bool DisablePersonalizedAds { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_stream")]
            public bool DisableStream { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_third_party_tracking")]
            public bool DisableThirdPartyTracking { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("disable_profile_country")]
            public bool DisableProfileCountry { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Inventory
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("formal_outfit")]
            public string FormalOutfit { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("superhero_outfit")]
            public string SuperheroOutfit { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("luxury_outfit")]
            public string LuxuryOutfit { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("streak_freeze")]
            public string StreakFreeze { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("gem_wager")]
            public int GemWager { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class AbOptions
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public LanguageStudied LanguageData { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("filter_stream")]
            public bool FilterStream { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("deactivated")]
            public bool Deactivated { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_clubs")]
            public bool PushClubs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("site_streak")]
            public int SiteStreak { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tts_base_url_http")]
            public string TtsBaseUrlHttp { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_edit_suggested")]
            public bool PushEditSuggested { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("transliterate")]
            public bool Transliterate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("languages")]
            public SCG.List<Language> Languages { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("location")]
            public string Location { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("bio")]
            public string Bio { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("insite_sentence_edited")]
            public bool InsiteSentenceEdited { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_comment")]
            public bool PushComment { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_activity_comment")]
            public bool NotifyActivityComment { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_streak_saver")]
            public bool EmailStreakSaver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("requires_parental_consent")]
            public bool RequiresParentalConsent { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_passed")]
            public bool PushPassed { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_assignment")]
            public bool NotifyAssignment { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("avatar")]
            public string Avatar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("gplus_id")]
            public string GplusId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("ui_language")]
            public string UiLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_announcement")]
            public bool NotifyAnnouncement { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("upload-self-service")]
            public bool UploadSelfService { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("creation_date")]
            public SDT CreationDate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("calendar")]
            public SCG.List<Calendar> Calendar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("daily_goal")]
            public int DailyGoal { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_leaderboards")]
            public bool PushLeaderboards { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_announcement")]
            public bool PushAnnouncement { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("ads_enabled")]
            public bool AdsEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("created_dt")]
            public long CreatedDt { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_self_observer")]
            public bool IsSelfObserver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notif_event_ids")]
            public SCGLO NotifEventIds { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_activity_reply")]
            public bool NotifyActivityReply { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_stream_post")]
            public bool PushStreamPost { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email")]
            public string Email { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("week_old_account")]
            public bool WeekOldAccount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_promotion")]
            public bool EmailPromotion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("timezone_offset")]
            public string TimezoneOffset { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_classrooms")]
            public int NumClassrooms { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("snooze_expiration_time")]
            public int SnoozeExpirationTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_observer")]
            public bool IsObserver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_weekly_report")]
            public bool NotifyWeeklyReport { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("delete-permissions")]
            public bool DeletePermissions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_comment")]
            public bool NotifyComment { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("insite_immersion_lingots")]
            public bool InsiteImmersionLingots { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_edit_suggested")]
            public bool NotifyEditSuggested { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_weekly_progress_report")]
            public bool NotifyWeeklyProgressReport { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("created")]
            public string Created { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("admin")]
            public bool Admin { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language")]
            public string LearningLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_classroom_leave")]
            public bool NotifyClassroomLeave { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_clubs")]
            public bool NotifyClubs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("freeze-permissions")]
            public bool FreezePermissions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_follow")]
            public bool NotifyFollow { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("last_streak")]
            public LastStreak LastStreak { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("auto_facebook_post")]
            public bool AutoFacebookPost { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("privacy_settings")]
            public PrivacySettings PrivacySettings { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_observees")]
            public int NumObservees { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_sms_disabled")]
            public bool NotificationSmsDisabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_wechat_enabled")]
            public bool NotificationWechatEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("dict_base_url")]
            public string DictBaseUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_follow")]
            public bool PushFollow { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_events_digest")]
            public bool EmailEventsDigest { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("facebook_id")]
            public string FacebookId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("browser_language")]
            public string BrowserLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("username")]
            public string Username { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_observer")]
            public bool HasObserver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tts_cdn_url")]
            public string TtsCdnUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_activity_reply")]
            public bool PushActivityReply { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notification_whatsapp_enabled")]
            public bool NotificationWhatsappEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tracking_properties")]
            public TrackingProperties TrackingProperties { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tts_base_url")]
            public string TtsBaseUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("trial_account")]
            public bool TrialAccount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("streak_extended_today")]
            public bool StreakExtendedToday { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_classroom_join")]
            public bool NotifyClassroomJoin { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("twitter_id")]
            public string TwitterId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_stream_post")]
            public bool NotifyStreamPost { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("fullname")]
            public string Fullname { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_streak_freeze_used")]
            public bool PushStreakFreezeUsed { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_activity_comment")]
            public bool PushActivityComment { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("timezone")]
            public string Timezone { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("id")]
            public int Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("current_time")]
            public long CurrentTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("microphone")]
            public bool Microphone { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("invite_url")]
            public string InviteUrl { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("sound_effects")]
            public bool SoundEffects { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("change-design")]
            public bool ChangeDesign { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("speaker")]
            public bool Speaker { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("inventory")]
            public User.Inventory Inventory { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language_string")]
            public string LearningLanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_schools_announcement")]
            public bool NotifySchoolsAnnouncement { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("cohort")]
            public object Cohort { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("ab_options")]
            public AbOptions AbOptions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_assignment_complete")]
            public bool NotifyAssignmentComplete { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_verified")]
            public bool EmailVerified { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("notify_pass")]
            public bool NotifyPass { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_word_of_the_day")]
            public bool EmailWordOfTheDay { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_promotion")]
            public bool PushPromotion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("rupees")]
            public int Rupees { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("email_streak_freeze_used")]
            public bool EmailStreakFreezeUsed { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("push_streak_saver")]
            public bool PushStreakSaver { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("autoplay")]
            public bool Autoplay { get; set; }
        }
    }

    #endregion
}
