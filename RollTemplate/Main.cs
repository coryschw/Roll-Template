using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RollTemplate
{
    public partial class Main : Form
    {
        private enum AbilityModifiers : int
        {
            None = 0,
            Strength = 1,
            Dexterity = 2,
            Constitution = 3,
            Intelligence = 4,
            Wisdom = 5,
            Charisma = 6
        };

        private string Template_String = "";
        private string npc_string = ""; //npc_
        private string selected_string = ""; //selected|
        private bool showclassactions = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Attack_Quick_Melee_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int) AbilityModifiers.Strength;
            Attack_Adv_Stat_combo.SelectedIndex = (int) AbilityModifiers.Strength;
            Attack_Atk_PB_check.Checked = true;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = false;
            Spell_Critical_check.Checked = false;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_Finesse_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int) AbilityModifiers.Dexterity;
            Attack_Adv_Stat_combo.SelectedIndex = (int) AbilityModifiers.Dexterity;
            Attack_Atk_PB_check.Checked = true;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = false;
            Spell_Critical_check.Checked = false;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_NPC_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = true;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int)AbilityModifiers.None;
            Attack_Adv_Stat_combo.SelectedIndex = (int)AbilityModifiers.None;
            Attack_Atk_PB_check.Checked = false;
            Attack_Adv_PB_check.Checked = false;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = false;
            Spell_Critical_check.Checked = false;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_Demo_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Header_RollType_combo.SelectedIndex = 0;
            Header_Title_text.Text = "Greatsword";
            Header_Sub_text.Text = "PC Name";
            Header_Sub_Right_text.Text = "Melee Attack";
            Attack_Enable_Atk_check.Checked = true; 
            Attack_Atk_Stat_combo.SelectedIndex = (int)AbilityModifiers.Strength;
            Attack_Atk_PB_check.Checked = true;
            Attack_Atk_Mod_numeric.Value = 0;
            Attack_Enable_Adv_check.Checked = true;
            Attack_Adv_Stat_combo.SelectedIndex = (int)AbilityModifiers.Strength;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Damage_Enable_Dmg_check.Checked = true;
            Damage_Dmg_NumDice_numeric.Value = 2;
            Damage_Dmg_Dice_combo.SelectedIndex = 1;
            Damage_Dmg_Stat_combo.SelectedIndex = (int)AbilityModifiers.Strength;
            Damage_Dmg_Mod_numeric.Value = 0;
            Damage_Dmg_Type_text.Text = "Slashing";
            Damage_Enable_Additional_check.Checked = false;
            Damage_Enable_Additional2_check.Checked = false;
            Critical_Enable_Crit_check.Checked = true;
            Critical_Crit_NumDice_numeric.Value = 2;
            Critical_Crit_Dice_combo.SelectedIndex = 1;
            Critical_Crit_Type_text.Text = "Slashing"; 
            Critical_Enable_Additional_check.Checked = false;
            Critical_Enable_Additional2_check.Checked = false;
            Spell_Enable_SpellInfo_check.Checked = false;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = false;
            Spell_Critical_check.Checked = false;
            Spell_Save_check.Checked = false;
            Custom_1_Label_text.Text = "";
            Custom_1_Text_text.Text = "";
            Custom_2_Label_text.Text = "";
            Custom_2_Text_text.Text = "";
            Custom_3_Label_text.Text = "";
            Custom_3_Text_text.Text = "";
            Custom_text.Text = "";
        }

        private void Attack_Quick_Int_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int) AbilityModifiers.Intelligence;
            Attack_Adv_Stat_combo.SelectedIndex = (int) AbilityModifiers.Intelligence;
            Attack_Atk_PB_check.Checked = true;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = true;
            Spell_Damage_check.Checked = true;
            Spell_Critical_check.Checked = true;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_Wis_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int)AbilityModifiers.Wisdom;
            Attack_Adv_Stat_combo.SelectedIndex = (int)AbilityModifiers.Wisdom;
            Attack_Atk_PB_check.Checked = true;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = true;
            Spell_Damage_check.Checked = true;
            Spell_Critical_check.Checked = true;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_Cha_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = true;
            Attack_Enable_Adv_check.Checked = true;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = true;
            Attack_Atk_Stat_combo.SelectedIndex = (int)AbilityModifiers.Charisma;
            Attack_Adv_Stat_combo.SelectedIndex = (int)AbilityModifiers.Charisma;
            Attack_Atk_PB_check.Checked = true;
            Attack_Adv_PB_check.Checked = true;
            Attack_Adv_Mod_numeric.Value = 0;
            Attack_Atk_Mod_numeric.Value = 0;
            Spell_Attack_check.Checked = true;
            Spell_Damage_check.Checked = true;
            Spell_Critical_check.Checked = true;
            Spell_Save_check.Checked = false;
        }

        private void Attack_Quick_Save_btn_Click(object sender, EventArgs e)
        {
            NPC_check.Checked = false;
            Attack_Enable_Atk_check.Checked = false;
            Attack_Enable_Adv_check.Checked = false;
            Damage_Enable_Dmg_check.Checked = true;
            Critical_Enable_Crit_check.Checked = false;
            Attack_Atk_PB_check.Checked = false;
            Attack_Adv_PB_check.Checked = false;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = true;
            Spell_Critical_check.Checked = false;
            Spell_Save_check.Checked = true;
            Spell_Save_Mod_combo.SelectedIndex = 0;
            Spell_Save_Mod_numeric.Value = 0;
            Spell_Save_Stat_combo.SelectedIndex = 0;
            Spell_Save_Success_text.Text = "";
        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            Initialize_Macro();
            /*************
             * HEADER
             ************/
            Add(((String) Header_RollType_combo.SelectedItem).ToLower()+"=1");
            if (Header_Title_text.TextLength > 0)
                Add("title=" + Header_Title_text.Text);
            if (Header_Sub_text.TextLength > 0)
                Add("subheader=" + Header_Sub_text.Text);
            if (Header_Sub_Right_text.TextLength > 0)
                Add("subheaderright=" + Header_Sub_Right_text.Text);
            if (Header_Sub2_text.TextLength > 0)
                Add("subheader2=" + Header_Sub2_text.Text);
            if (Header_Sub2_Right_text.TextLength > 0)
                Add("subheaderright2=" + Header_Sub2_Right_text.Text);
            if (Header_Emote_text.TextLength > 0)
                Add("emote=" + Header_Emote_text.Text);

            /*************
             * ATTACK
             ************/
            if(Attack_Enable_Atk_check.Checked)
            {
                string field_name = "attack";
                if (Spell_Attack_check.Checked)
                {
                    Add("spellshowattack=1");
                    field_name = "spellattack";
                }
                string AttackString = field_name + "=[[1d20";
                if (Attack_Atk_Stat_combo.SelectedIndex > 0)
                    AttackString = AttackString + " + @{" + selected_string + npc_string + ComboBoxItem_To_LowerString(Attack_Atk_Stat_combo.SelectedItem) + "_mod}";
                if (Attack_Atk_PB_check.Checked)
                    AttackString = AttackString + " + @{" + selected_string + "PB}";
                if (Attack_Atk_Mod_numeric.Value != 0)
                    AttackString = AttackString + " + " + Attack_Atk_Mod_numeric.Value;
                Add(AttackString + "]]");
                
                /*************
                 * ATTACK ADVANTAGE/DISADVANTAGE
                 ************/
                if (Attack_Enable_Adv_check.Checked)
                {
                    field_name = "attackadv";
                    if (Spell_Attack_check.Checked)
                    {
                        Add("spellshowattackadv=1");
                        field_name = "spellattackadv";
                    }
                    AttackString = field_name + "=[[1d20";
                    if (Attack_Adv_Stat_combo.SelectedIndex > 0)
                        AttackString = AttackString + " + @{" + selected_string + npc_string + ComboBoxItem_To_LowerString(Attack_Adv_Stat_combo.SelectedItem) + "_mod}";
                    if (Attack_Adv_PB_check.Checked)
                        AttackString = AttackString + " + @{" + selected_string + "PB}";
                    if (Attack_Adv_Mod_numeric.Value != 0)
                        AttackString = AttackString + " + " + Attack_Adv_Mod_numeric.Value;
                    Add(AttackString + "]]");
                }
            }
            /**************
             * DAMAGE
             *************/
            if (Damage_Enable_Dmg_check.Checked)
            {
                string field_name = "damage";
                if (Damage_Type_Healing_radio.Checked)
                {
                    Add("spellshowhealing=1");
                    field_name = "spellhealing";
                }
                else if (Spell_Damage_check.Checked)
                {
                    Add("spellshowdamage=1");
                    field_name = "spelldamage";
                }
                string DamageString = field_name + "=[[" + Damage_Dmg_NumDice_numeric.Value + ComboBoxItem_To_LowerString(Damage_Dmg_Dice_combo.SelectedItem);
                if (Damage_Dmg_Stat_combo.SelectedIndex > 0)
                    DamageString = DamageString + " + @{" + selected_string + npc_string + ComboBoxItem_To_LowerString(Damage_Dmg_Stat_combo.SelectedItem) + "_mod}";
                if (Damage_Dmg_Mod_numeric.Value != 0)
                    DamageString = DamageString + " + " + Damage_Dmg_Mod_numeric.Value;
                DamageString = DamageString + "]]";
                if(Damage_Dmg_Type_text.TextLength > 0)
                    DamageString = DamageString + " " + Damage_Dmg_Type_text.Text;
                if (Damage_Enable_Additional_check.Checked)
                {
                    DamageString = DamageString + " + [[" + Damage_Additional_Dice_text.Text + "]] " + Damage_Additional_Type_text.Text; 
                }
                if (Damage_Enable_Additional2_check.Checked)
                {
                    DamageString = DamageString + " + [[" + Damage_Additional2_Dice_text.Text + "]] " + Damage_Additional2_Type_text.Text;
                }
                Add(DamageString);
            }

            /**************
             * CRITICAL DAMAGE
             *************/
            if (Critical_Enable_Crit_check.Checked)
            {
                string field_name = "critdamage";
                if (Spell_Critical_check.Checked)
                {
                    Add("spellcancrit=1");
                    field_name = "spellcritdamage";
                }
                string CriticalString = field_name + "=[[" + Critical_Crit_NumDice_numeric.Value + ComboBoxItem_To_LowerString(Critical_Crit_Dice_combo.SelectedItem);
                CriticalString = CriticalString + "]]";
                if (Critical_Crit_Type_text.TextLength > 0)
                    CriticalString = CriticalString + " " + Critical_Crit_Type_text.Text;
                if (Critical_Enable_Additional_check.Checked)
                {
                    CriticalString = CriticalString + " + [[" + Critical_Additional_Dice_text.Text + "]] " + Critical_Additional_Type_text.Text;
                }
                if (Critical_Enable_Additional2_check.Checked)
                {
                    CriticalString = CriticalString + " + [[" + Critical_Additional2_Dice_text.Text + "]] " + Critical_Additional2_Type_text.Text;
                }
                Add(CriticalString);
            }

            /******************
             * Spells
             *****************/
            if (Spell_Enable_SpellInfo_check.Checked)
            {
                Add("spellshowinfoblock=1");
                Add("spellgainedfrom=" + Spell_Class_text.Text);
                Add("spellcasttime=" + Spell_CastTime_text.Text);
                Add("spellduration=" + Spell_Duration_text.Text);
                Add("spelltarget=" + Spell_Target_text.Text);
                Add("spellrange=" + Spell_Range_text.Text);
                string SpellComponents = "";
                if (Spell_Material_check.Checked)
                {
                    SpellComponents = "M";
                    if (Spell_Material_text.TextLength > 0)
                        SpellComponents = SpellComponents + " (" + Spell_Material_text.Text + ")";
                }
                if (Spell_Somatic_check.Checked)
                    SpellComponents = "S " + SpellComponents;
                if (Spell_Vocal_check.Checked)
                    SpellComponents = "V " + SpellComponents;
                Add("spellcomponents=" + SpellComponents);
            }

            if (Spell_Save_check.Checked)
            {
                Add("spellshowsavethrow=1");
                string Save = "";
                if (NPC_check.Checked)
                    Save = "spellsavedc=[[@{" + selected_string + Spell_Save_Mod_numeric.Value + "}]]";
                else
                    Save = "spellsavedc=[[8+@{" + selected_string + "PB}+@{" + selected_string + "" + ComboBoxItem_To_LowerString(Spell_Save_Mod_combo.SelectedItem) + "_mod}]]";
                Add(Save);
                Add("spellsavestat=" + (String)Spell_Save_Stat_combo.SelectedItem);
                Add("spellsavesuccess=" + Spell_Save_Success_text.Text);
            }

            if (Spell_Description_check.Checked)
            {
                Add("spellshowdesc=1");
                Add("spelldescription=" + Spell_Description_text.Text);
            }

            if (Spell_Higher_Level_check.Checked)
            {
                Add("spellshowhigherlvl=1");
                Add("spellhigherlevel=" + Spell_Higher_Level_check.Text);
            }

            if (Spell_Effect_check.Checked)
            {
                Add("spellshoweffects=1");
                Add("spelleffect=" + Spell_Effect_text.Text);
            }

            if (Custom_1_Label_text.TextLength > 0)
            {
                if (!showclassactions)
                {
                    Add("showclassactions=1");
                    showclassactions = true;
                }
                Add(Custom_1_Label_text.Text + "=" + Custom_1_Text_text.Text);
            }
            if (Custom_2_Label_text.TextLength > 0)
            {
                if (!showclassactions)
                {
                    Add("showclassactions=1");
                    showclassactions = true;
                }
                Add(Custom_2_Label_text.Text + "=" + Custom_2_Text_text.Text);
            }
            if (Custom_3_Label_text.TextLength > 0)
            {
                if (!showclassactions)
                {
                    Add("showclassactions=1");
                    showclassactions = true;
                }
                Add(Custom_3_Label_text.Text + "=" + Custom_3_Text_text.Text);
            }
            if (Custom_text.TextLength > 0)
            {
                if (!showclassactions)
                {
                    Add("showclassactions=1");
                    showclassactions = true;
                }
                Add(Custom_text.Text);
            }

            Generate_Popup form = new Generate_Popup();
            form.InitializeScreen(Template_String);
            form.ShowDialog();
        }

        private void Initialize_Macro()
        {
            Template_String = "&{template:5eDefault}";
            showclassactions = false;
        }

        private void Add(string value)
        {
            Template_String = Template_String + " {{" + value + "}}";
        }

        private string ComboBoxItem_To_LowerString(object input)
        {
            string value = ((String)input).ToLower();
            return value;
        }

        private void Spell_Save_check_CheckedChanged(object sender, EventArgs e)
        {
            Spell_Save_Success_check.Checked = Spell_Save_check.Checked;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            /*
             * Text Boxes
             */
            Header_Title_text.Text = "";
            Header_Sub_text.Text = "";
            Header_Sub_Right_text.Text = "";
            Header_Sub2_text.Text = "";
            Header_Sub2_Right_text.Text = "";
            Header_Emote_text.Text = "";
            Damage_Dmg_Type_text.Text = "";
            Damage_Additional_Dice_text.Text = "";
            Damage_Additional_Type_text.Text = "";
            Damage_Additional2_Dice_text.Text = "";
            Damage_Additional2_Type_text.Text = "";
            Critical_Crit_Type_text.Text = "";
            Critical_Additional_Dice_text.Text = "";
            Critical_Additional_Type_text.Text = "";
            Critical_Additional2_Dice_text.Text = "";
            Critical_Additional2_Type_text.Text = "";
            Spell_Class_text.Text = "";
            Spell_CastTime_text.Text = "";
            Spell_Duration_text.Text = "";
            Spell_Target_text.Text = "";
            Spell_Range_text.Text = "";
            Spell_Material_text.Text = "";
            Spell_Description_text.Text = "";
            Spell_Effect_text.Text = "";
            Spell_Save_Success_text.Text = "";
            Spell_Higher_Level_text.Text = "";
            Custom_1_Label_text.Text = "";
            Custom_1_Text_text.Text = "";
            Custom_2_Label_text.Text = "";
            Custom_2_Text_text.Text = "";
            Custom_3_Label_text.Text = "";
            Custom_3_Text_text.Text = "";
            Custom_text.Text = "";

            /*
             * Combo Boxes
             */
            Header_RollType_combo.SelectedIndex = 0;
            Attack_Atk_Stat_combo.SelectedIndex = 0;
            Attack_Adv_Stat_combo.SelectedIndex = 0;
            Damage_Dmg_Dice_combo.SelectedIndex = 0;
            Damage_Dmg_Stat_combo.SelectedIndex = 0;
            Critical_Crit_Dice_combo.SelectedIndex = 0;
            Spell_Save_Mod_combo.SelectedIndex = 0;
            Spell_Save_Stat_combo.SelectedIndex = 0;



            /*
             * Check Boxes
             */
            Attack_Enable_Atk_check.Checked = false;
            Attack_Enable_Adv_check.Checked = false;
            Attack_Atk_PB_check.Checked = false;
            Attack_Adv_PB_check.Checked = false;
            Damage_Enable_Dmg_check.Checked = false;
            Damage_Enable_Additional_check.Checked = false;
            Damage_Enable_Additional2_check.Checked = false;
            Critical_Enable_Crit_check.Checked = false;
            Critical_Enable_Additional_check.Checked = false;
            Critical_Enable_Additional2_check.Checked = false;
            Spell_Enable_SpellInfo_check.Checked = false;
            Spell_Vocal_check.Checked = false;
            Spell_Somatic_check.Checked = false;
            Spell_Material_check.Checked = false;
            Spell_Attack_check.Checked = false;
            Spell_Damage_check.Checked = false;
            Spell_Save_check.Checked = false;
            Spell_Critical_check.Checked = false;
            Spell_Description_check.Checked = false;
            Spell_Effect_check.Checked = false;
            Spell_Higher_Level_check.Checked = false;

            /*
             * Numeric
             */
            Attack_Atk_Mod_numeric.Value = 0;
            Attack_Adv_Mod_numeric.Value = 0;
            Damage_Dmg_NumDice_numeric.Value = 1;
            Damage_Dmg_Mod_numeric.Value = 0;
            Critical_Crit_NumDice_numeric.Value = 1;
            Spell_Save_Mod_numeric.Value = 0;
        }

        private void NPC_check_CheckedChanged(object sender, EventArgs e)
        {
            if (NPC_check.Checked)
            {
                npc_string = "npc_";
                Attack_Atk_PB_check.Checked = false;
                Attack_Adv_PB_check.Checked = false;
                Attack_Atk_PB_check.Enabled = false;
                Attack_Adv_PB_check.Enabled = false;
                Attack_Atk_Stat_combo.SelectedIndex = 0;
                Attack_Adv_Stat_combo.SelectedIndex = 0;
                Attack_Atk_Stat_combo.Enabled = false;
                Attack_Adv_Stat_combo.Enabled = false;
                Damage_Dmg_Stat_combo.SelectedIndex = 0;
                Damage_Dmg_Stat_combo.Enabled = false;
                Spell_Mod_Label.Visible = false;
                Spell_Save_Mod_combo.Visible = false;
                Spell_Modifier_Label.Text = "NPC Save DC";
            }
            else
            {
                npc_string = "";
                Attack_Atk_PB_check.Enabled = true;
                Attack_Adv_PB_check.Enabled = true;
                Attack_Atk_Stat_combo.Enabled = true;
                Attack_Adv_Stat_combo.Enabled = true;
                Damage_Dmg_Stat_combo.Enabled = true;
                Spell_Mod_Label.Visible = true;
                Spell_Save_Mod_combo.Visible = true;
                Spell_Modifier_Label.Text = "Save Modifier";
            }
        }

        private void Selected_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Selected_check.Checked)
                selected_string = "selected|";
            else
                selected_string = "";
        }

        private void Damage_Type_Healing_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Damage_Type_Healing_radio.Checked)
            {
                Damage_Enable_Dmg_check.Text = "Enable Healing";
                Damage_Enable_Additional_check.Text = "Enable Additional Healing";
                Damage_Enable_Additional2_check.Text = "Enable Additional Healing";
                Damage_label1.Text = "Healing Type";
                Damage_label2.Text = "Healing Type";
                Damage_label3.Text = "Healing Type";
                Damge_Sub_Label1.Text = "Ex: HP";
                Damge_Sub_Label2.Text = "Ex: HP";
                Damge_Sub_Label3.Text = "Ex: HP";
            }
            else
            {
                Damage_Enable_Dmg_check.Text = "Enable Damage";
                Damage_Enable_Additional_check.Text = "Enable Additional Damage";
                Damage_Enable_Additional2_check.Text = "Enable Additional Damage";
                Damage_label1.Text = "Damage Type";
                Damage_label2.Text = "Damage Type";
                Damage_label3.Text = "Damage Type";
                Damge_Sub_Label1.Text = "Ex: Piercing";
                Damge_Sub_Label2.Text = "Ex: Necrotic";
                Damge_Sub_Label3.Text = "Ex: Necrotic";
            }
        }

    }
}
