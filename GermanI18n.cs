using System;
using System.Collections.Generic;
using ChickenAPI.Core.i18n;
using ChickenAPI.Game._i18n;

namespace SaltyEmu.RedisWrappers.Languages
{
    public class GermanI18n
    {
        public static Dictionary<PlayerMessages, string> Languages = new Dictionary<PlayerMessages, string>
        {
            #region Character Creation
            { PlayerMessages.CHARACTER_NAME_INVALID, "Try other name!" },
            { PlayerMessages.CHARACTER_NAME_ALREADY_TAKEN, "Character name is already taken" },
            #endregion
            #region Upgrade
            { PlayerMessages.UPGRADE_RARIFY_SUCCESS,"Gamble successfull!"},
            # endregion
            #region Skills
            { PlayerMessages.SKILL_YOU_LEARNED_SKILL_X,"Skill {0} successfully learned"},
            #endregion
            # region Changements
            { PlayerMessages.CHARACTER_YOUR_CLASS_CHANGED_TO_X,"You have change your class to {0}"},
            { PlayerMessages.CHARACTER_X_CLASS_CHANGED_TO_Y,"You have changed from {0} class to {1} class"},
            { PlayerMessages.CHARACTER_YOUR_GENDER_CHANGED_TO_X,"You have changed your gender to {0}"}
            { PlayerMessages.CHARACTER_X_GENDER_CHANGED_TO_Y,"You have changed your gender from {0} to {1}"},
            { PlayerMessages.CHARACTER_YOUR_FACTION_CHANGED_TO_X,"You have changed your faction to {0}"},
            { PlayerMessages.CHARACTER_X_FACTION_CHANGED_TO_Y,"You have change your faction from {0} to {1}"},
            # endregion
            # region Family
            { PlayerMessages.FAMILY_PLAYERX_HAS_ALREADY_FAMILY,"You can't invite {0} to your family because he already has a family!"},
            { PlayerMessages.FAMILY_ALREADY_LEADER,"You already are the leader of the family!"},
            { PlayerMessages.FAMILY_PLAYERX_JOINED_FAMILYX,"{0} has joined the family!"},
            { PlayerMessages.FAMILY_YOU_NEED_TO_BE_LEADER,"You need to be the family leader!"},
            # endregion
            # region You don't have requirements
            { PlayerMessages.YOU_DONT_HAVE_ENOUGH_GOLD,"You don't have enought gold to do that!"},
            { PlayerMessages.YOU_DONT_HAVE_ENOUGH_REPUTATION,"You don't have enought reputation to do that!"},
            { PlayerMessages.YOU_DONT_HAVE_ENOUGH_SPACE_IN_INVENTORY,"You don't have enought space in your inventory!"},            
            # endregion
            # region Relations
            { PlayerMessages.FRIEND_X_INVITED_YOU_TO_JOIN_HIS_FRIENDLIST,"{0} has sent you a friendship petition "},
            { PlayerMessages.FRIEND_X_IS_NOW_IN_YOUR_FRIENDLIST,"{0} is now your friend!"},
            # endregion
            # region Pets
            { PlayerMessages.PETS_YOU_GET_X_AS_A_NEW_PET,"Congratulations,{0} is your new pet!"},
            { PlayerMessages.PETS_YOU_GET_X_AS_A_NEW_PARTNER,"Congratulations,{0} is your new partner!"},
            # endregion
            # region Group
            { PlayerMessages.GROUP_PLAYER_X_INVITED_YOU_TO_JOIN_HIS_GROUP, "{0} has invited you to join a group"},
            { PlayerMessages.GROUP_PLAYER_X_INVITED_TO_YOUR_GROUP, "You have invited {0} to join your group"},
            { PlayerMessages.GROUP_PLAYER_X_JOINED_YOUR_GROUP, "{0} has joined your group" },
            { PlayerMessages.GROUP_YOU_JOINED_GROUP_OF_PLAYER_X, "you have joined {0}'s group" },
            # endregion
        };
    }
}