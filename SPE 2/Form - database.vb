Public Class GUI_Database
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents British_Standard_Bulb_names As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_pic01 As System.Windows.Forms.PictureBox
    Friend WithEvents British_Standard_Bulb_Web_Depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_Web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_Y_cm As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_A_cm2 As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_Ixx_cm4 As System.Windows.Forms.ListBox
    Friend WithEvents web_depth_label As System.Windows.Forms.Label
    Friend WithEvents web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents bulb_radius_label As System.Windows.Forms.Label
    Friend WithEvents Flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_names As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_Bulb_pic_box As System.Windows.Forms.GroupBox
    Friend WithEvents British_Standard_EA_pic_box As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents British_Standard_EA_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_EA_ix_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_y_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_EA_A_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_corus_groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents British_Standard_Bulb_corus As System.Windows.Forms.GroupBox
    Friend WithEvents British_Standard_EA_corus As System.Windows.Forms.GroupBox
    Friend WithEvents British_Standard_UEA_corus As System.Windows.Forms.GroupBox
    Friend WithEvents British_Standard_UEA_a_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_y_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_I_box As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_names As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_Profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents British_Standard_UEA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents British_Standard_UEA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_flange_thickness As System.Windows.Forms.Label
    Friend WithEvents FDA_flange_breadth As System.Windows.Forms.Label
    Friend WithEvents FDA_profile_depth As System.Windows.Forms.Label
    Friend WithEvents FDA_web_depth As System.Windows.Forms.Label
    Friend WithEvents FDA_web_thickness As System.Windows.Forms.Label
    Friend WithEvents British_Standard_UEA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA01 As System.Windows.Forms.GroupBox
    Friend WithEvents FDA01_pic As System.Windows.Forms.GroupBox
    Friend WithEvents DIN_Standard_EIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_EIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_EIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_EIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_EIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_UIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_UIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_UIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_UIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_Standard_UIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents European_Standard_UIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents European_Standard_UIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents European_Standard_UIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents European_Standard_UIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents European_Standard_UIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_EIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_EIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_EIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_EIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_EIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_UIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_UIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_UIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_UIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_Standard_UIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japanese_Standard_EIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents Japanese_Standard_EIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Japanese_Standard_EIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Japanese_Standard_EIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japanese_Standard_EIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Korean_Standard_EIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Korean_Standard_EIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Korean_Standard_EIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Korean_Standard_EIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Korean_Standard_EIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_EIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_EIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_EIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_EIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_EIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_UIA_FDA_names As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_UIA_FDA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_UIA_FDA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_UIA_FDA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Polish_Standard_UIA_FDA_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Standard_Blades_names As System.Windows.Forms.ListBox
    Friend WithEvents Standard_Blades_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Standard_Blades_profiles_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA01_blade_pic As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Standard_Blades_profiles_depth_label As System.Windows.Forms.Label
    Friend WithEvents Standard_Blades_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents Equal_Angles As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Equal_Angles_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_y As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_area As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_I As System.Windows.Forms.ListBox
    Friend WithEvents Equal_Angles_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents Equal_Angles_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents Equal_Angles_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents Equal_Angles_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents IP_Jumbo_bulb_groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents IP_Jumbo_bulb As System.Windows.Forms.GroupBox
    Friend WithEvents IP_Jumbo_Bulb_names As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_Y As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_A As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_i As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents IP_Jumbo_Bulb_bulb_radius_label As System.Windows.Forms.Label
    Friend WithEvents IP_Jumbo_Bulb_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents IP_Jumbo_Bulb_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents IP_Jumbo_Bulb_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents inexa_profil_EA_and_NJA As System.Windows.Forms.GroupBox
    Friend WithEvents IP_pic As System.Windows.Forms.GroupBox
    Friend WithEvents NJA_names As System.Windows.Forms.ListBox
    Friend WithEvents NJA_y As System.Windows.Forms.ListBox
    Friend WithEvents NJA_area As System.Windows.Forms.ListBox
    Friend WithEvents NJA_I As System.Windows.Forms.ListBox
    Friend WithEvents NJA_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents NJA_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents NJA_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents NJA_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents IP_Rolled_Bulb_Flats As System.Windows.Forms.GroupBox
    Friend WithEvents IP_Rolled_Bulb_Flats_pic As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents IP_rolled_bulb_radius_label As System.Windows.Forms.Label
    Friend WithEvents IP_rolled_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents IP_rolled_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents IP_rolled_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents IP_rolled_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_names As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_a As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_i As System.Windows.Forms.ListBox
    Friend WithEvents IP_rolled_centroid As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents DIN_HBP_a As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_i As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_names As System.Windows.Forms.ListBox
    Friend WithEvents bulb_pic01 As System.Windows.Forms.GroupBox
    Friend WithEvents bulb_radius_din_label As System.Windows.Forms.Label
    Friend WithEvents bulb_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents bulb_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents bulb_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents DIN_HBP_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents DIN_HBP_y As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_names As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_y As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_a As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_i As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents ISO_HBP_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_bulb01 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_title13 As System.Windows.Forms.Label
    Friend WithEvents bulb02_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_bulb_radius As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_names As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_a As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_i As System.Windows.Forms.ListBox
    Friend WithEvents bulb02_bulb_radius_label As System.Windows.Forms.Label
    Friend WithEvents bulb02_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents bulb02_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents bulb02_pic01 As System.Windows.Forms.PictureBox
    Friend WithEvents bulb02_pic02 As System.Windows.Forms.PictureBox
    Friend WithEvents bulb02_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents bulb02_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_bulb02 As System.Windows.Forms.GroupBox
    Friend WithEvents FDA_bulb02_picbox As System.Windows.Forms.GroupBox
    Friend WithEvents IP_T As System.Windows.Forms.GroupBox
    Friend WithEvents IP_T_groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents IP_T_names As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents T_centroid As System.Windows.Forms.ListBox
    Friend WithEvents T_a As System.Windows.Forms.ListBox
    Friend WithEvents T_i As System.Windows.Forms.ListBox
    Friend WithEvents T_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents T_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents T_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents T_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents T_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents T_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents T_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents T_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIU As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_A As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_i As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_Korean_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_A As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_i As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_nordic_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_A As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_i As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIA_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIA_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIA_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIA_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents FDA_LIA_euro_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_euro_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_A As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_i As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_ISO_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_PIC As System.Windows.Forms.GroupBox
    Friend WithEvents FDA_LIA_japanese_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_centroid As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_A As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_i As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_LIA_japanese_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_korean As System.Windows.Forms.GroupBox
    Friend WithEvents FDA_UIA_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents FDA_UIA_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_UIA_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents FDA_UIA_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents FDA_UIA_box As System.Windows.Forms.GroupBox
    Friend WithEvents FDA_UIA_japanese_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_japanese_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_korean_names As System.Windows.Forms.ListBox
    Friend WithEvents FDA_UIA_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents update_text As System.Windows.Forms.Button
    Friend WithEvents stf_box As System.Windows.Forms.GroupBox
    Friend WithEvents tekens_tree As System.Windows.Forms.TreeView
    Friend WithEvents corus As System.Windows.Forms.PictureBox
    Friend WithEvents corus_link As System.Windows.Forms.LinkLabel
    Friend WithEvents inexa_link As System.Windows.Forms.LinkLabel
    Friend WithEvents inexa As System.Windows.Forms.PictureBox
    Friend WithEvents ISO_link As System.Windows.Forms.LinkLabel
    Friend WithEvents ISO As System.Windows.Forms.PictureBox
    Friend WithEvents DIN_link As System.Windows.Forms.LinkLabel
    Friend WithEvents DIN As System.Windows.Forms.PictureBox
    Friend WithEvents british_link As System.Windows.Forms.LinkLabel
    Friend WithEvents british As System.Windows.Forms.PictureBox
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ImageList_stiffeners_icons As System.Windows.Forms.ImageList
    Friend WithEvents Japan_industry_Equal_unequal As System.Windows.Forms.GroupBox
    Friend WithEvents Japan_industry_unequal_Y As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_A As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_I As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Unequal_names As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_names As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Japan_industry_Equal_Y As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_A As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_I As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_flange_breadth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_web_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_web_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_profile_depth As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_Equal_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents Japan_industry_unequal_flange_thickness As System.Windows.Forms.ListBox
    Friend WithEvents japan_industry_flange_breadth_label As System.Windows.Forms.Label
    Friend WithEvents japan_industry_flange_thickness_label As System.Windows.Forms.Label
    Friend WithEvents japan_industry_web_thickness_label As System.Windows.Forms.Label
    Friend WithEvents japan_industry_web_depth_label As System.Windows.Forms.Label
    Friend WithEvents japan_industry_profile_depth_label As System.Windows.Forms.Label
    Friend WithEvents Japan_Industry_Standard_box As System.Windows.Forms.GroupBox
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents Label_count As System.Windows.Forms.Label
    Friend WithEvents box_standard As System.Windows.Forms.GroupBox
    Friend WithEvents Label_a01_unit As System.Windows.Forms.Label
    Friend WithEvents Label_m01_unit As System.Windows.Forms.Label
    Friend WithEvents Label_a01 As System.Windows.Forms.Label
    Friend WithEvents Label_m01 As System.Windows.Forms.Label
    Friend WithEvents box04 As System.Windows.Forms.GroupBox
    Friend WithEvents label_a04_unit As System.Windows.Forms.Label
    Friend WithEvents label_m04_unit As System.Windows.Forms.Label
    Friend WithEvents label_a04 As System.Windows.Forms.Label
    Friend WithEvents label_m04 As System.Windows.Forms.Label
    Friend WithEvents box01 As System.Windows.Forms.GroupBox
    Friend WithEvents label_a03_unit As System.Windows.Forms.Label
    Friend WithEvents label_m03_unit As System.Windows.Forms.Label
    Friend WithEvents label_a03 As System.Windows.Forms.Label
    Friend WithEvents label_m03 As System.Windows.Forms.Label
    Friend WithEvents box02 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_a02_unit As System.Windows.Forms.Label
    Friend WithEvents Label_m02_unit As System.Windows.Forms.Label
    Friend WithEvents label_a02 As System.Windows.Forms.Label
    Friend WithEvents label_m02 As System.Windows.Forms.Label
    Friend WithEvents box06 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y06_unit As System.Windows.Forms.Label
    Friend WithEvents label_a06_unit As System.Windows.Forms.Label
    Friend WithEvents label_m06_unit As System.Windows.Forms.Label
    Friend WithEvents label_y06 As System.Windows.Forms.Label
    Friend WithEvents label_a06 As System.Windows.Forms.Label
    Friend WithEvents label_m06 As System.Windows.Forms.Label
    Friend WithEvents box05 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y05_unit As System.Windows.Forms.Label
    Friend WithEvents label_a05_unit As System.Windows.Forms.Label
    Friend WithEvents label_m05_unit As System.Windows.Forms.Label
    Friend WithEvents label_y05 As System.Windows.Forms.Label
    Friend WithEvents label_a05 As System.Windows.Forms.Label
    Friend WithEvents label_m05 As System.Windows.Forms.Label
    Friend WithEvents label_y04_unit As System.Windows.Forms.Label
    Friend WithEvents label_y04 As System.Windows.Forms.Label
    Friend WithEvents Label_y01_unit As System.Windows.Forms.Label
    Friend WithEvents Label_y01 As System.Windows.Forms.Label
    Friend WithEvents box09 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y09_unit As System.Windows.Forms.Label
    Friend WithEvents label_a09_unit As System.Windows.Forms.Label
    Friend WithEvents label_m09_unit As System.Windows.Forms.Label
    Friend WithEvents label_y09 As System.Windows.Forms.Label
    Friend WithEvents label_a09 As System.Windows.Forms.Label
    Friend WithEvents label_m09 As System.Windows.Forms.Label
    Friend WithEvents box10 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y10_unit As System.Windows.Forms.Label
    Friend WithEvents label_a10_unit As System.Windows.Forms.Label
    Friend WithEvents label_m10_unit As System.Windows.Forms.Label
    Friend WithEvents label_y10 As System.Windows.Forms.Label
    Friend WithEvents label_a10 As System.Windows.Forms.Label
    Friend WithEvents label_m10 As System.Windows.Forms.Label
    Friend WithEvents box11 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y11_unit As System.Windows.Forms.Label
    Friend WithEvents label_a11_unit As System.Windows.Forms.Label
    Friend WithEvents label_m11_unit As System.Windows.Forms.Label
    Friend WithEvents label_y11 As System.Windows.Forms.Label
    Friend WithEvents label_a11 As System.Windows.Forms.Label
    Friend WithEvents label_m11 As System.Windows.Forms.Label
    Friend WithEvents box12 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y12_unit As System.Windows.Forms.Label
    Friend WithEvents label_a12_unit As System.Windows.Forms.Label
    Friend WithEvents label_m12_unit As System.Windows.Forms.Label
    Friend WithEvents label_y12 As System.Windows.Forms.Label
    Friend WithEvents label_a12 As System.Windows.Forms.Label
    Friend WithEvents label_m12 As System.Windows.Forms.Label
    Friend WithEvents label_y03_unit As System.Windows.Forms.Label
    Friend WithEvents label_y03 As System.Windows.Forms.Label
    Friend WithEvents box07 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y07_unit As System.Windows.Forms.Label
    Friend WithEvents label_a07_unit As System.Windows.Forms.Label
    Friend WithEvents label_m07_unit As System.Windows.Forms.Label
    Friend WithEvents label_y07 As System.Windows.Forms.Label
    Friend WithEvents label_a07 As System.Windows.Forms.Label
    Friend WithEvents label_m07 As System.Windows.Forms.Label
    Friend WithEvents box08 As System.Windows.Forms.GroupBox
    Friend WithEvents label_y08_unit As System.Windows.Forms.Label
    Friend WithEvents label_a08_unit As System.Windows.Forms.Label
    Friend WithEvents label_m08_unit As System.Windows.Forms.Label
    Friend WithEvents label_y08 As System.Windows.Forms.Label
    Friend WithEvents label_a08 As System.Windows.Forms.Label
    Friend WithEvents label_m08 As System.Windows.Forms.Label
    Friend WithEvents Label_y02_unit As System.Windows.Forms.Label
    Friend WithEvents label_y02 As System.Windows.Forms.Label
    Friend WithEvents textbox_m01 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a01 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y01 As System.Windows.Forms.TextBox
    Friend WithEvents Label_title01 As System.Windows.Forms.Label
    Friend WithEvents label_title02 As System.Windows.Forms.Label
    Friend WithEvents textbox_y06 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a06 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m06 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y05 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a05 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m05 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a04 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y04 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m04 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y09 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a09 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m09 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y10 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a10 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m10 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y11 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a11 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m11 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a12 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y12 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m12 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y03 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a03 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m03 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y07 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a07 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m07 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y08 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a08 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m08 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_a02 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m02 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_y02 As System.Windows.Forms.TextBox
    Friend WithEvents box03 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_title06 As System.Windows.Forms.Label
    Friend WithEvents Label_title05 As System.Windows.Forms.Label
    Friend WithEvents Label_title04 As System.Windows.Forms.Label
    Friend WithEvents Label_title09 As System.Windows.Forms.Label
    Friend WithEvents Label_title10 As System.Windows.Forms.Label
    Friend WithEvents Label_title11 As System.Windows.Forms.Label
    Friend WithEvents Label_title12 As System.Windows.Forms.Label
    Friend WithEvents Label_title03 As System.Windows.Forms.Label
    Friend WithEvents Label_title07 As System.Windows.Forms.Label
    Friend WithEvents Label_title08 As System.Windows.Forms.Label
    Friend WithEvents box13 As System.Windows.Forms.GroupBox
    Friend WithEvents box13_y13 As System.Windows.Forms.GroupBox
    Friend WithEvents box13_a13 As System.Windows.Forms.GroupBox
    Friend WithEvents box13_m13 As System.Windows.Forms.GroupBox
    Friend WithEvents textbox_y13 As System.Windows.Forms.TextBox
    Friend WithEvents label_y13_unit As System.Windows.Forms.Label
    Friend WithEvents label_a13_unit As System.Windows.Forms.Label
    Friend WithEvents textbox_a13 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_m13 As System.Windows.Forms.TextBox
    Friend WithEvents Label_m13_unit As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Database))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("British Standard UEA", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DIN Standard EIA", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DIN Standard UIA", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DIN Standard HBP", 1, 1)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("European Standard LIA", 2, 2)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("European Standard UIA", 2, 2)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO Standard EIA", 2, 2)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO Standard LIA", 2, 2)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO Standard UIA", 2, 2)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO Standard HBP", 1, 1)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Japanese Standard EIA", 2, 2)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Japanese Standard LIA", 2, 2)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Japanese Standard UIA", 2, 2)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Korean Standard EIA", 2, 2)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Korean Standard LIA", 2, 2)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Korean Standard UIA", 2, 2)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nordic Standard LIA", 2, 2)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Polish Standard EIA", 2, 2)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Polish Standard UIA", 2, 2)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Standard Blades", 0, 0)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bulbs (Japanese, Korean, Nordic, Polish)", 1, 1)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FDA", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("British Standard Bulb", 1, 1)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("British Standard EA", 2, 2)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("British Standard UEA (Corus)", 2, 2)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Corus", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Equal Angles", 2, 2)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NJA Standard", 2, 2)
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jumbo Bulb Flats", 1, 1)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rolled Bulb Flats", 1, 1)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("T section", 3, 3)
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inexa Profil", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Equal Angles ", 2, 2)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unequal Angles ", 2, 2)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Japan Industry Standard", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34})
        Me.British_Standard_Bulb_corus = New System.Windows.Forms.GroupBox
        Me.box06 = New System.Windows.Forms.GroupBox
        Me.label_y06_unit = New System.Windows.Forms.Label
        Me.textbox_y06 = New System.Windows.Forms.TextBox
        Me.label_a06_unit = New System.Windows.Forms.Label
        Me.textbox_a06 = New System.Windows.Forms.TextBox
        Me.label_m06_unit = New System.Windows.Forms.Label
        Me.textbox_m06 = New System.Windows.Forms.TextBox
        Me.label_y06 = New System.Windows.Forms.Label
        Me.label_a06 = New System.Windows.Forms.Label
        Me.label_m06 = New System.Windows.Forms.Label
        Me.British_Standard_Bulb_Y_cm = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_A_cm2 = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_Ixx_cm4 = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_bulb_radius = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_flange_breadth = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_Web_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_Web_Depth = New System.Windows.Forms.ListBox
        Me.Label_title06 = New System.Windows.Forms.Label
        Me.British_Standard_Bulb_names = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_pic_box = New System.Windows.Forms.GroupBox
        Me.bulb_radius_label = New System.Windows.Forms.Label
        Me.web_depth_label = New System.Windows.Forms.Label
        Me.British_Standard_Bulb_pic01 = New System.Windows.Forms.PictureBox
        Me.Flange_breadth_label = New System.Windows.Forms.Label
        Me.web_thickness_label = New System.Windows.Forms.Label
        Me.British_Standard_EA_names = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_profile_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_web_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_web_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_flange_breadth = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_flange_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_pic_box = New System.Windows.Forms.GroupBox
        Me.British_Standard_EA_flange_thickness_label = New System.Windows.Forms.Label
        Me.British_Standard_EA_flange_breadth_label = New System.Windows.Forms.Label
        Me.British_Standard_EA_profile_depth_label = New System.Windows.Forms.Label
        Me.British_Standard_EA_web_depth_label = New System.Windows.Forms.Label
        Me.British_Standard_EA_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.British_Standard_EA_corus = New System.Windows.Forms.GroupBox
        Me.British_Standard_EA_A_box = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_y_box = New System.Windows.Forms.ListBox
        Me.British_Standard_EA_ix_box = New System.Windows.Forms.ListBox
        Me.Label_title05 = New System.Windows.Forms.Label
        Me.box05 = New System.Windows.Forms.GroupBox
        Me.label_y05_unit = New System.Windows.Forms.Label
        Me.textbox_y05 = New System.Windows.Forms.TextBox
        Me.label_a05_unit = New System.Windows.Forms.Label
        Me.textbox_a05 = New System.Windows.Forms.TextBox
        Me.label_m05_unit = New System.Windows.Forms.Label
        Me.textbox_m05 = New System.Windows.Forms.TextBox
        Me.label_y05 = New System.Windows.Forms.Label
        Me.label_a05 = New System.Windows.Forms.Label
        Me.label_m05 = New System.Windows.Forms.Label
        Me.British_Standard_UEA_corus = New System.Windows.Forms.GroupBox
        Me.British_Standard_UEA_a_box = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_y_box = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_I_box = New System.Windows.Forms.ListBox
        Me.Label_title04 = New System.Windows.Forms.Label
        Me.British_Standard_UEA_flange_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_web_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_web_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_flange_breadth = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_profile_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_corus_groupbox = New System.Windows.Forms.GroupBox
        Me.British_Standard_UEA_flange_thickness_label = New System.Windows.Forms.Label
        Me.British_Standard_UEA_flange_breadth_label = New System.Windows.Forms.Label
        Me.British_Standard_UEA_Profile_depth_label = New System.Windows.Forms.Label
        Me.British_Standard_UEA_web_depth_label = New System.Windows.Forms.Label
        Me.British_Standard_UEA_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.box04 = New System.Windows.Forms.GroupBox
        Me.label_y04_unit = New System.Windows.Forms.Label
        Me.textbox_a04 = New System.Windows.Forms.TextBox
        Me.label_a04_unit = New System.Windows.Forms.Label
        Me.textbox_y04 = New System.Windows.Forms.TextBox
        Me.label_m04_unit = New System.Windows.Forms.Label
        Me.textbox_m04 = New System.Windows.Forms.TextBox
        Me.label_y04 = New System.Windows.Forms.Label
        Me.label_a04 = New System.Windows.Forms.Label
        Me.label_m04 = New System.Windows.Forms.Label
        Me.British_Standard_UEA_names = New System.Windows.Forms.ListBox
        Me.FDA01 = New System.Windows.Forms.GroupBox
        Me.Standard_Blades_web_thickness = New System.Windows.Forms.ListBox
        Me.Standard_Blades_profiles_depth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_UIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_UIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.Polish_Standard_UIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_UIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_EIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_EIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.Polish_Standard_EIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.Polish_Standard_EIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.Korean_Standard_EIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.Korean_Standard_EIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.Korean_Standard_EIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.Korean_Standard_EIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.Japanese_Standard_EIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.Japanese_Standard_EIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.Japanese_Standard_EIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.Japanese_Standard_EIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_UIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_UIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.ISO_Standard_UIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_UIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_UIA_FDA_names = New System.Windows.Forms.ListBox
        Me.DIN_Standard_EIA_FDA_names = New System.Windows.Forms.ListBox
        Me.Label_title01 = New System.Windows.Forms.Label
        Me.British_Standard_UEA_FDA_names = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_EIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_EIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.ISO_Standard_EIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.ISO_Standard_EIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.European_Standard_UIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.European_Standard_UIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.European_Standard_UIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.European_Standard_UIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_UIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_UIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.DIN_Standard_UIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_UIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_EIA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_EIA_FDA_web_thickness = New System.Windows.Forms.ListBox
        Me.DIN_Standard_EIA_FDA_web_depth = New System.Windows.Forms.ListBox
        Me.DIN_Standard_EIA_FDA_profile_depth = New System.Windows.Forms.ListBox
        Me.British_Standard_UEA_FDA_flange_breadth = New System.Windows.Forms.ListBox
        Me.Standard_Blades_names = New System.Windows.Forms.ListBox
        Me.Polish_Standard_UIA_FDA_names = New System.Windows.Forms.ListBox
        Me.Polish_Standard_EIA_FDA_names = New System.Windows.Forms.ListBox
        Me.Korean_Standard_EIA_FDA_names = New System.Windows.Forms.ListBox
        Me.Japanese_Standard_EIA_FDA_names = New System.Windows.Forms.ListBox
        Me.ISO_Standard_UIA_FDA_names = New System.Windows.Forms.ListBox
        Me.FDA01_pic = New System.Windows.Forms.GroupBox
        Me.FDA_flange_thickness = New System.Windows.Forms.Label
        Me.FDA_flange_breadth = New System.Windows.Forms.Label
        Me.FDA_profile_depth = New System.Windows.Forms.Label
        Me.FDA_web_depth = New System.Windows.Forms.Label
        Me.FDA_web_thickness = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.FDA01_blade_pic = New System.Windows.Forms.GroupBox
        Me.Standard_Blades_profiles_depth_label = New System.Windows.Forms.Label
        Me.Standard_Blades_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.box01 = New System.Windows.Forms.GroupBox
        Me.Label_y01_unit = New System.Windows.Forms.Label
        Me.textbox_a01 = New System.Windows.Forms.TextBox
        Me.Label_a01_unit = New System.Windows.Forms.Label
        Me.textbox_y01 = New System.Windows.Forms.TextBox
        Me.Label_m01_unit = New System.Windows.Forms.Label
        Me.textbox_m01 = New System.Windows.Forms.TextBox
        Me.Label_y01 = New System.Windows.Forms.Label
        Me.Label_a01 = New System.Windows.Forms.Label
        Me.Label_m01 = New System.Windows.Forms.Label
        Me.ISO_Standard_EIA_FDA_names = New System.Windows.Forms.ListBox
        Me.European_Standard_UIA_FDA_names = New System.Windows.Forms.ListBox
        Me.box_standard = New System.Windows.Forms.GroupBox
        Me.british = New System.Windows.Forms.PictureBox
        Me.DIN_link = New System.Windows.Forms.LinkLabel
        Me.DIN = New System.Windows.Forms.PictureBox
        Me.ISO_link = New System.Windows.Forms.LinkLabel
        Me.ISO = New System.Windows.Forms.PictureBox
        Me.inexa_link = New System.Windows.Forms.LinkLabel
        Me.inexa = New System.Windows.Forms.PictureBox
        Me.corus_link = New System.Windows.Forms.LinkLabel
        Me.corus = New System.Windows.Forms.PictureBox
        Me.Label_count = New System.Windows.Forms.Label
        Me.tekens_tree = New System.Windows.Forms.TreeView
        Me.ImageList_stiffeners_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.british_link = New System.Windows.Forms.LinkLabel
        Me.label_title = New System.Windows.Forms.Label
        Me.inexa_profil_EA_and_NJA = New System.Windows.Forms.GroupBox
        Me.NJA_y = New System.Windows.Forms.ListBox
        Me.NJA_area = New System.Windows.Forms.ListBox
        Me.NJA_I = New System.Windows.Forms.ListBox
        Me.NJA_flange_thickness = New System.Windows.Forms.ListBox
        Me.NJA_flange_breadth = New System.Windows.Forms.ListBox
        Me.NJA_web_thickness = New System.Windows.Forms.ListBox
        Me.NJA_web_depth = New System.Windows.Forms.ListBox
        Me.box09 = New System.Windows.Forms.GroupBox
        Me.label_y09_unit = New System.Windows.Forms.Label
        Me.textbox_y09 = New System.Windows.Forms.TextBox
        Me.label_a09_unit = New System.Windows.Forms.Label
        Me.textbox_a09 = New System.Windows.Forms.TextBox
        Me.label_m09_unit = New System.Windows.Forms.Label
        Me.textbox_m09 = New System.Windows.Forms.TextBox
        Me.label_y09 = New System.Windows.Forms.Label
        Me.label_a09 = New System.Windows.Forms.Label
        Me.label_m09 = New System.Windows.Forms.Label
        Me.Label_title09 = New System.Windows.Forms.Label
        Me.Equal_Angles = New System.Windows.Forms.ListBox
        Me.Equal_Angles_y = New System.Windows.Forms.ListBox
        Me.Equal_Angles_area = New System.Windows.Forms.ListBox
        Me.Equal_Angles_I = New System.Windows.Forms.ListBox
        Me.Equal_Angles_flange_thickness = New System.Windows.Forms.ListBox
        Me.Equal_Angles_flange_breadth = New System.Windows.Forms.ListBox
        Me.Equal_Angles_web_thickness = New System.Windows.Forms.ListBox
        Me.Equal_Angles_web_depth = New System.Windows.Forms.ListBox
        Me.IP_pic = New System.Windows.Forms.GroupBox
        Me.Equal_Angles_flange_breadth_label = New System.Windows.Forms.Label
        Me.Equal_Angles_flange_thickness_label = New System.Windows.Forms.Label
        Me.Equal_Angles_web_thickness_label = New System.Windows.Forms.Label
        Me.Equal_Angles_web_depth_label = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.NJA_names = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_bulb = New System.Windows.Forms.GroupBox
        Me.box10 = New System.Windows.Forms.GroupBox
        Me.label_y10_unit = New System.Windows.Forms.Label
        Me.textbox_y10 = New System.Windows.Forms.TextBox
        Me.label_a10_unit = New System.Windows.Forms.Label
        Me.textbox_a10 = New System.Windows.Forms.TextBox
        Me.label_m10_unit = New System.Windows.Forms.Label
        Me.textbox_m10 = New System.Windows.Forms.TextBox
        Me.label_y10 = New System.Windows.Forms.Label
        Me.label_a10 = New System.Windows.Forms.Label
        Me.label_m10 = New System.Windows.Forms.Label
        Me.Label_title10 = New System.Windows.Forms.Label
        Me.IP_Jumbo_Bulb_Y = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_A = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_i = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_bulb_radius = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_flange_breadth = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_web_thickness = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_web_depth = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_Bulb_names = New System.Windows.Forms.ListBox
        Me.IP_Jumbo_bulb_groupbox = New System.Windows.Forms.GroupBox
        Me.IP_Jumbo_Bulb_web_thickness_label = New System.Windows.Forms.Label
        Me.IP_Jumbo_Bulb_bulb_radius_label = New System.Windows.Forms.Label
        Me.IP_Jumbo_Bulb_flange_breadth_label = New System.Windows.Forms.Label
        Me.IP_Jumbo_Bulb_web_depth_label = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.IP_Rolled_Bulb_Flats = New System.Windows.Forms.GroupBox
        Me.Label_title11 = New System.Windows.Forms.Label
        Me.IP_rolled_centroid = New System.Windows.Forms.ListBox
        Me.IP_rolled_a = New System.Windows.Forms.ListBox
        Me.IP_rolled_i = New System.Windows.Forms.ListBox
        Me.IP_rolled_bulb_radius = New System.Windows.Forms.ListBox
        Me.IP_rolled_flange_breadth = New System.Windows.Forms.ListBox
        Me.IP_rolled_web_thickness = New System.Windows.Forms.ListBox
        Me.IP_rolled_web_depth = New System.Windows.Forms.ListBox
        Me.IP_rolled_names = New System.Windows.Forms.ListBox
        Me.IP_Rolled_Bulb_Flats_pic = New System.Windows.Forms.GroupBox
        Me.IP_rolled_bulb_radius_label = New System.Windows.Forms.Label
        Me.IP_rolled_flange_breadth_label = New System.Windows.Forms.Label
        Me.IP_rolled_web_thickness_label = New System.Windows.Forms.Label
        Me.IP_rolled_web_depth_label = New System.Windows.Forms.Label
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.box11 = New System.Windows.Forms.GroupBox
        Me.label_y11_unit = New System.Windows.Forms.Label
        Me.textbox_y11 = New System.Windows.Forms.TextBox
        Me.label_a11_unit = New System.Windows.Forms.Label
        Me.textbox_a11 = New System.Windows.Forms.TextBox
        Me.label_m11_unit = New System.Windows.Forms.Label
        Me.textbox_m11 = New System.Windows.Forms.TextBox
        Me.label_y11 = New System.Windows.Forms.Label
        Me.label_a11 = New System.Windows.Forms.Label
        Me.label_m11 = New System.Windows.Forms.Label
        Me.FDA_bulb01 = New System.Windows.Forms.GroupBox
        Me.ISO_HBP_y = New System.Windows.Forms.ListBox
        Me.ISO_HBP_a = New System.Windows.Forms.ListBox
        Me.ISO_HBP_i = New System.Windows.Forms.ListBox
        Me.ISO_HBP_flange_breadth = New System.Windows.Forms.ListBox
        Me.ISO_HBP_web_thickness = New System.Windows.Forms.ListBox
        Me.ISO_HBP_bulb_radius = New System.Windows.Forms.ListBox
        Me.ISO_HBP_profile_depth = New System.Windows.Forms.ListBox
        Me.DIN_HBP_y = New System.Windows.Forms.ListBox
        Me.DIN_HBP_a = New System.Windows.Forms.ListBox
        Me.DIN_HBP_i = New System.Windows.Forms.ListBox
        Me.box12 = New System.Windows.Forms.GroupBox
        Me.label_y12_unit = New System.Windows.Forms.Label
        Me.textbox_a12 = New System.Windows.Forms.TextBox
        Me.label_a12_unit = New System.Windows.Forms.Label
        Me.textbox_y12 = New System.Windows.Forms.TextBox
        Me.label_m12_unit = New System.Windows.Forms.Label
        Me.textbox_m12 = New System.Windows.Forms.TextBox
        Me.label_y12 = New System.Windows.Forms.Label
        Me.label_a12 = New System.Windows.Forms.Label
        Me.label_m12 = New System.Windows.Forms.Label
        Me.Label_title12 = New System.Windows.Forms.Label
        Me.DIN_HBP_names = New System.Windows.Forms.ListBox
        Me.DIN_HBP_flange_breadth = New System.Windows.Forms.ListBox
        Me.DIN_HBP_web_thickness = New System.Windows.Forms.ListBox
        Me.DIN_HBP_bulb_radius = New System.Windows.Forms.ListBox
        Me.DIN_HBP_profile_depth = New System.Windows.Forms.ListBox
        Me.bulb_pic01 = New System.Windows.Forms.GroupBox
        Me.bulb_radius_din_label = New System.Windows.Forms.Label
        Me.bulb_flange_breadth_label = New System.Windows.Forms.Label
        Me.bulb_profile_depth_label = New System.Windows.Forms.Label
        Me.bulb_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.ISO_HBP_names = New System.Windows.Forms.ListBox
        Me.FDA_bulb02 = New System.Windows.Forms.GroupBox
        Me.box13 = New System.Windows.Forms.GroupBox
        Me.box13_y13 = New System.Windows.Forms.GroupBox
        Me.textbox_y13 = New System.Windows.Forms.TextBox
        Me.label_y13_unit = New System.Windows.Forms.Label
        Me.box13_a13 = New System.Windows.Forms.GroupBox
        Me.label_a13_unit = New System.Windows.Forms.Label
        Me.textbox_a13 = New System.Windows.Forms.TextBox
        Me.box13_m13 = New System.Windows.Forms.GroupBox
        Me.Label_m13_unit = New System.Windows.Forms.Label
        Me.textbox_m13 = New System.Windows.Forms.TextBox
        Me.Label_title13 = New System.Windows.Forms.Label
        Me.bulb02_a = New System.Windows.Forms.ListBox
        Me.bulb02_centroid = New System.Windows.Forms.ListBox
        Me.bulb02_i = New System.Windows.Forms.ListBox
        Me.bulb02_flange_breadth = New System.Windows.Forms.ListBox
        Me.bulb02_web_thickness = New System.Windows.Forms.ListBox
        Me.bulb02_bulb_radius = New System.Windows.Forms.ListBox
        Me.bulb02_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_bulb02_picbox = New System.Windows.Forms.GroupBox
        Me.bulb02_bulb_radius_label = New System.Windows.Forms.Label
        Me.bulb02_flange_breadth_label = New System.Windows.Forms.Label
        Me.bulb02_profile_depth_label = New System.Windows.Forms.Label
        Me.bulb02_web_thickness_label = New System.Windows.Forms.Label
        Me.bulb02_pic02 = New System.Windows.Forms.PictureBox
        Me.bulb02_pic01 = New System.Windows.Forms.PictureBox
        Me.bulb02_names = New System.Windows.Forms.ListBox
        Me.IP_T = New System.Windows.Forms.GroupBox
        Me.box03 = New System.Windows.Forms.GroupBox
        Me.label_y03_unit = New System.Windows.Forms.Label
        Me.textbox_y03 = New System.Windows.Forms.TextBox
        Me.label_a03_unit = New System.Windows.Forms.Label
        Me.textbox_a03 = New System.Windows.Forms.TextBox
        Me.label_m03_unit = New System.Windows.Forms.Label
        Me.textbox_m03 = New System.Windows.Forms.TextBox
        Me.label_y03 = New System.Windows.Forms.Label
        Me.label_a03 = New System.Windows.Forms.Label
        Me.label_m03 = New System.Windows.Forms.Label
        Me.T_flange_breadth = New System.Windows.Forms.ListBox
        Me.Label_title03 = New System.Windows.Forms.Label
        Me.T_centroid = New System.Windows.Forms.ListBox
        Me.T_a = New System.Windows.Forms.ListBox
        Me.T_i = New System.Windows.Forms.ListBox
        Me.ListBox5 = New System.Windows.Forms.ListBox
        Me.T_flange_thickness = New System.Windows.Forms.ListBox
        Me.T_web_thickness = New System.Windows.Forms.ListBox
        Me.T_web_depth = New System.Windows.Forms.ListBox
        Me.IP_T_groupbox = New System.Windows.Forms.GroupBox
        Me.T_web_thickness_label = New System.Windows.Forms.Label
        Me.T_flange_thickness_label = New System.Windows.Forms.Label
        Me.T_flange_breadth_label = New System.Windows.Forms.Label
        Me.T_web_depth_label = New System.Windows.Forms.Label
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.IP_T_names = New System.Windows.Forms.ListBox
        Me.FDA_LIU = New System.Windows.Forms.GroupBox
        Me.FDA_LIA_japanese_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_centroid = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_A = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_i = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_japanese_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_centroid = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_A = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_i = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_nordic_names = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_centroid = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_A = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_i = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_Korean_names = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_centroid = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_A = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_i = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_ISO_names = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_centroid = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_A = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_i = New System.Windows.Forms.ListBox
        Me.box07 = New System.Windows.Forms.GroupBox
        Me.label_y07_unit = New System.Windows.Forms.Label
        Me.textbox_y07 = New System.Windows.Forms.TextBox
        Me.label_a07_unit = New System.Windows.Forms.Label
        Me.textbox_a07 = New System.Windows.Forms.TextBox
        Me.label_m07_unit = New System.Windows.Forms.Label
        Me.textbox_m07 = New System.Windows.Forms.TextBox
        Me.label_y07 = New System.Windows.Forms.Label
        Me.label_a07 = New System.Windows.Forms.Label
        Me.label_m07 = New System.Windows.Forms.Label
        Me.Label_title07 = New System.Windows.Forms.Label
        Me.FDA_LIA_euro_names = New System.Windows.Forms.ListBox
        Me.ListBox6 = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_LIA_euro_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_LIA_PIC = New System.Windows.Forms.GroupBox
        Me.FDA_LIA_flange_thickness_label = New System.Windows.Forms.Label
        Me.FDA_LIA_flange_breadth_label = New System.Windows.Forms.Label
        Me.FDA_LIA_profile_depth_label = New System.Windows.Forms.Label
        Me.FDA_LIA_web_depth_label = New System.Windows.Forms.Label
        Me.FDA_LIA_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.FDA_LIA_japanese_names = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_korean = New System.Windows.Forms.GroupBox
        Me.FDA_UIA_korean_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_UIA_korean_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_UIA_korean_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_UIA_korean_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_UIA_korean_web_depth = New System.Windows.Forms.ListBox
        Me.box08 = New System.Windows.Forms.GroupBox
        Me.label_y08_unit = New System.Windows.Forms.Label
        Me.textbox_y08 = New System.Windows.Forms.TextBox
        Me.label_a08_unit = New System.Windows.Forms.Label
        Me.textbox_a08 = New System.Windows.Forms.TextBox
        Me.label_m08_unit = New System.Windows.Forms.Label
        Me.textbox_m08 = New System.Windows.Forms.TextBox
        Me.label_y08 = New System.Windows.Forms.Label
        Me.label_a08 = New System.Windows.Forms.Label
        Me.label_m08 = New System.Windows.Forms.Label
        Me.Label_title08 = New System.Windows.Forms.Label
        Me.FDA_UIA_japanese_names = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_profile_depth = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_flange_breadth = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_web_thickness = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_flange_thickness = New System.Windows.Forms.ListBox
        Me.FDA_UIA_japanese_web_depth = New System.Windows.Forms.ListBox
        Me.FDA_UIA_box = New System.Windows.Forms.GroupBox
        Me.FDA_UIA_flange_thickness_label = New System.Windows.Forms.Label
        Me.FDA_UIA_flange_breadth_label = New System.Windows.Forms.Label
        Me.FDA_UIA_profile_depth_label = New System.Windows.Forms.Label
        Me.FDA_UIA_web_depth_label = New System.Windows.Forms.Label
        Me.FDA_UIA_web_thickness_label = New System.Windows.Forms.Label
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.FDA_UIA_korean_names = New System.Windows.Forms.ListBox
        Me.update_text = New System.Windows.Forms.Button
        Me.cancel = New System.Windows.Forms.Button
        Me.stf_box = New System.Windows.Forms.GroupBox
        Me.Japan_industry_Equal_unequal = New System.Windows.Forms.GroupBox
        Me.Japan_industry_unequal_flange_thickness = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_flange_thickness = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_Y = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_A = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_I = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_flange_breadth = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_web_thickness = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_web_depth = New System.Windows.Forms.ListBox
        Me.Japan_industry_unequal_profile_depth = New System.Windows.Forms.ListBox
        Me.box02 = New System.Windows.Forms.GroupBox
        Me.Label_y02_unit = New System.Windows.Forms.Label
        Me.textbox_y02 = New System.Windows.Forms.TextBox
        Me.Label_a02_unit = New System.Windows.Forms.Label
        Me.textbox_a02 = New System.Windows.Forms.TextBox
        Me.Label_m02_unit = New System.Windows.Forms.Label
        Me.textbox_m02 = New System.Windows.Forms.TextBox
        Me.label_y02 = New System.Windows.Forms.Label
        Me.label_a02 = New System.Windows.Forms.Label
        Me.label_m02 = New System.Windows.Forms.Label
        Me.label_title02 = New System.Windows.Forms.Label
        Me.Japan_Industry_Standard_box = New System.Windows.Forms.GroupBox
        Me.japan_industry_profile_depth_label = New System.Windows.Forms.Label
        Me.japan_industry_flange_breadth_label = New System.Windows.Forms.Label
        Me.japan_industry_flange_thickness_label = New System.Windows.Forms.Label
        Me.japan_industry_web_thickness_label = New System.Windows.Forms.Label
        Me.japan_industry_web_depth_label = New System.Windows.Forms.Label
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.Japan_industry_Equal_Y = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_A = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_I = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_flange_breadth = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_web_thickness = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_web_depth = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_profile_depth = New System.Windows.Forms.ListBox
        Me.Japan_industry_Unequal_names = New System.Windows.Forms.ListBox
        Me.Japan_industry_Equal_names = New System.Windows.Forms.ListBox
        Me.British_Standard_Bulb_corus.SuspendLayout()
        Me.box06.SuspendLayout()
        Me.British_Standard_Bulb_pic_box.SuspendLayout()
        CType(Me.British_Standard_Bulb_pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.British_Standard_EA_pic_box.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.British_Standard_EA_corus.SuspendLayout()
        Me.box05.SuspendLayout()
        Me.British_Standard_UEA_corus.SuspendLayout()
        Me.British_Standard_UEA_corus_groupbox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box04.SuspendLayout()
        Me.FDA01.SuspendLayout()
        Me.FDA01_pic.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FDA01_blade_pic.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box01.SuspendLayout()
        Me.box_standard.SuspendLayout()
        CType(Me.british, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inexa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.corus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inexa_profil_EA_and_NJA.SuspendLayout()
        Me.box09.SuspendLayout()
        Me.IP_pic.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IP_Jumbo_bulb.SuspendLayout()
        Me.box10.SuspendLayout()
        Me.IP_Jumbo_bulb_groupbox.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IP_Rolled_Bulb_Flats.SuspendLayout()
        Me.IP_Rolled_Bulb_Flats_pic.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box11.SuspendLayout()
        Me.FDA_bulb01.SuspendLayout()
        Me.box12.SuspendLayout()
        Me.bulb_pic01.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FDA_bulb02.SuspendLayout()
        Me.box13.SuspendLayout()
        Me.box13_y13.SuspendLayout()
        Me.box13_a13.SuspendLayout()
        Me.box13_m13.SuspendLayout()
        Me.FDA_bulb02_picbox.SuspendLayout()
        CType(Me.bulb02_pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bulb02_pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IP_T.SuspendLayout()
        Me.box03.SuspendLayout()
        Me.IP_T_groupbox.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FDA_LIU.SuspendLayout()
        Me.box07.SuspendLayout()
        Me.FDA_LIA_PIC.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FDA_UIA_japanese_korean.SuspendLayout()
        Me.box08.SuspendLayout()
        Me.FDA_UIA_box.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stf_box.SuspendLayout()
        Me.Japan_industry_Equal_unequal.SuspendLayout()
        Me.box02.SuspendLayout()
        Me.Japan_Industry_Standard_box.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'British_Standard_Bulb_corus
        '
        Me.British_Standard_Bulb_corus.Controls.Add(Me.box06)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_Y_cm)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_A_cm2)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_Ixx_cm4)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_bulb_radius)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_flange_breadth)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_Web_thickness)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_Web_Depth)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.Label_title06)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_names)
        Me.British_Standard_Bulb_corus.Controls.Add(Me.British_Standard_Bulb_pic_box)
        Me.British_Standard_Bulb_corus.Location = New System.Drawing.Point(6, 12)
        Me.British_Standard_Bulb_corus.Name = "British_Standard_Bulb_corus"
        Me.British_Standard_Bulb_corus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_corus.Size = New System.Drawing.Size(868, 356)
        Me.British_Standard_Bulb_corus.TabIndex = 0
        Me.British_Standard_Bulb_corus.TabStop = False
        Me.British_Standard_Bulb_corus.Text = "British Standard Bulb (Corus)"
        Me.British_Standard_Bulb_corus.Visible = False
        '
        'box06
        '
        Me.box06.Controls.Add(Me.label_y06_unit)
        Me.box06.Controls.Add(Me.textbox_y06)
        Me.box06.Controls.Add(Me.label_a06_unit)
        Me.box06.Controls.Add(Me.textbox_a06)
        Me.box06.Controls.Add(Me.label_m06_unit)
        Me.box06.Controls.Add(Me.textbox_m06)
        Me.box06.Controls.Add(Me.label_y06)
        Me.box06.Controls.Add(Me.label_a06)
        Me.box06.Controls.Add(Me.label_m06)
        Me.box06.Font = New System.Drawing.Font("David", 10.8!)
        Me.box06.Location = New System.Drawing.Point(207, 38)
        Me.box06.Name = "box06"
        Me.box06.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box06.Size = New System.Drawing.Size(364, 136)
        Me.box06.TabIndex = 15
        Me.box06.TabStop = False
        Me.box06.Text = "נתוני החיזוק"
        '
        'label_y06_unit
        '
        Me.label_y06_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y06_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y06_unit.Name = "label_y06_unit"
        Me.label_y06_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y06_unit.TabIndex = 8
        Me.label_y06_unit.Text = "[cm]"
        '
        'textbox_y06
        '
        Me.textbox_y06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y06.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y06.Name = "textbox_y06"
        Me.textbox_y06.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y06.TabIndex = 7
        '
        'label_a06_unit
        '
        Me.label_a06_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a06_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a06_unit.Name = "label_a06_unit"
        Me.label_a06_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a06_unit.TabIndex = 6
        Me.label_a06_unit.Text = "[cm^2]"
        '
        'textbox_a06
        '
        Me.textbox_a06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a06.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a06.Name = "textbox_a06"
        Me.textbox_a06.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a06.TabIndex = 5
        '
        'label_m06_unit
        '
        Me.label_m06_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m06_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m06_unit.Name = "label_m06_unit"
        Me.label_m06_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m06_unit.TabIndex = 4
        Me.label_m06_unit.Text = "[cm^4]"
        '
        'textbox_m06
        '
        Me.textbox_m06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m06.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m06.Name = "textbox_m06"
        Me.textbox_m06.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m06.TabIndex = 3
        '
        'label_y06
        '
        Me.label_y06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y06.Location = New System.Drawing.Point(188, 94)
        Me.label_y06.Name = "label_y06"
        Me.label_y06.Size = New System.Drawing.Size(164, 24)
        Me.label_y06.TabIndex = 2
        Me.label_y06.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a06
        '
        Me.label_a06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a06.Location = New System.Drawing.Point(188, 63)
        Me.label_a06.Name = "label_a06"
        Me.label_a06.Size = New System.Drawing.Size(164, 24)
        Me.label_a06.TabIndex = 1
        Me.label_a06.Text = "שטח חתך החיזוק"
        '
        'label_m06
        '
        Me.label_m06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m06.Location = New System.Drawing.Point(188, 32)
        Me.label_m06.Name = "label_m06"
        Me.label_m06.Size = New System.Drawing.Size(164, 24)
        Me.label_m06.TabIndex = 0
        Me.label_m06.Text = "מומנט אינרציה (Ix)"
        '
        'British_Standard_Bulb_Y_cm
        '
        Me.British_Standard_Bulb_Y_cm.ItemHeight = 16
        Me.British_Standard_Bulb_Y_cm.Items.AddRange(New Object() {"7.2", "7.07", "6.96", "8.37", "8.31", "8.18", "7.92", "9.66", "9.49", "9.36", "9.11", "10.9", "10.7", "10.6", "10.4", "12.2", "12.1", "11.9", "11.8", "11.7", "13.6", "13.4", "13.2", "13", "14.8", "14.7", "14.6", "14.4", "16.2", "16", "15.8", "17.5", "17.4", "17.2", "17", "18.9", "18.7", "18.5", "20.2", "20.1", "19.9", "19.7", "21.5", "21.3", "21.1", "20.9", "23.6", "23.5", "23.2", "23", "22.8", "25.8", "25.5", "25.2", "25", "27.7", "27.4", "26.9", "26.3"})
        Me.British_Standard_Bulb_Y_cm.Location = New System.Drawing.Point(248, 268)
        Me.British_Standard_Bulb_Y_cm.Name = "British_Standard_Bulb_Y_cm"
        Me.British_Standard_Bulb_Y_cm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_Y_cm.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_Y_cm.TabIndex = 10
        Me.British_Standard_Bulb_Y_cm.Visible = False
        '
        'British_Standard_Bulb_A_cm2
        '
        Me.British_Standard_Bulb_A_cm2.ItemHeight = 16
        Me.British_Standard_Bulb_A_cm2.Items.AddRange(New Object() {"9.31", "10.5", "11.7", "11.7", "12.4", "13.8", "16.6", "14.6", "16.2", "17.8", "21.8", "18.9", "20.7", "22.5", "25.2", "22.6", "23.6", "25.6", "27.6", "29.6", "26.8", "29", "31.2", "33.4", "31.2", "32.4", "34.9", "37.3", "36.1", "38.7", "41.3", "41.2", "42.6", "45.5", "48.4", "46.7", "49.7", "52.8", "52.6", "54.2", "57.4", "60.6", "58.8", "62.2", "65.5", "69", "67.8", "69.6", "73.3", "77", "80.7", "77.4", "81.4", "85.4", "89.4", "89.7", "94.1", "103", "115"})
        Me.British_Standard_Bulb_A_cm2.Location = New System.Drawing.Point(244, 244)
        Me.British_Standard_Bulb_A_cm2.Name = "British_Standard_Bulb_A_cm2"
        Me.British_Standard_Bulb_A_cm2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_A_cm2.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_A_cm2.TabIndex = 9
        Me.British_Standard_Bulb_A_cm2.Visible = False
        '
        'British_Standard_Bulb_Ixx_cm4
        '
        Me.British_Standard_Bulb_Ixx_cm4.ItemHeight = 16
        Me.British_Standard_Bulb_Ixx_cm4.Items.AddRange(New Object() {"133", "148", "164", "228", "241", "266", "316", "373", "411", "448", "544", "609", "665", "717", "799", "902", "941", "1020", "1090", "1160", "1296", "1400", "1500", "1590", "1800", "1860", "2000", "2130", "2477", "2610", "2770", "3223", "3330", "3550", "3760", "4190", "4460", "4720", "5370", "5530", "5850", "6170", "6760", "7160", "7540", "7920", "9213", "9470", "9980", "10490", "10980", "12280", "12930", "13580", "14220", "16460", "17260", "18860", "21180"})
        Me.British_Standard_Bulb_Ixx_cm4.Location = New System.Drawing.Point(244, 200)
        Me.British_Standard_Bulb_Ixx_cm4.Name = "British_Standard_Bulb_Ixx_cm4"
        Me.British_Standard_Bulb_Ixx_cm4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_Ixx_cm4.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_Ixx_cm4.TabIndex = 8
        Me.British_Standard_Bulb_Ixx_cm4.Visible = False
        '
        'British_Standard_Bulb_bulb_radius
        '
        Me.British_Standard_Bulb_bulb_radius.ItemHeight = 16
        Me.British_Standard_Bulb_bulb_radius.Items.AddRange(New Object() {"5", "5", "5", "5.5", "5.5", "5.5", "5.5", "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "10", "11", "11", "11", "12", "12", "12", "12", "13", "13", "13", "14", "14", "14", "14", "15", "15", "15", "15", "16.5", "16.5", "16.5", "16.5", "16.5", "18", "18", "18", "18", "19.5", "19.5", "19.5", "19.5"})
        Me.British_Standard_Bulb_bulb_radius.Location = New System.Drawing.Point(180, 268)
        Me.British_Standard_Bulb_bulb_radius.Name = "British_Standard_Bulb_bulb_radius"
        Me.British_Standard_Bulb_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_bulb_radius.TabIndex = 7
        Me.British_Standard_Bulb_bulb_radius.Visible = False
        '
        'British_Standard_Bulb_flange_breadth
        '
        Me.British_Standard_Bulb_flange_breadth.ItemHeight = 16
        Me.British_Standard_Bulb_flange_breadth.Items.AddRange(New Object() {"17", "17", "17", "19", "19", "19", "19", "22", "22", "22", "22", "25", "25", "25", "25", "28", "28", "28", "28", "28", "31", "31", "31", "31", "34", "34", "34", "34", "37", "37", "37", "40", "40", "40", "40", "43", "43", "43", "46", "46", "46", "46", "49", "49", "49", "49", "53.5", "53.5", "53.5", "53.5", "53.5", "58", "58", "58", "58", "62.5", "62.5", "62.5", "62.5"})
        Me.British_Standard_Bulb_flange_breadth.Location = New System.Drawing.Point(180, 244)
        Me.British_Standard_Bulb_flange_breadth.Name = "British_Standard_Bulb_flange_breadth"
        Me.British_Standard_Bulb_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_flange_breadth.TabIndex = 6
        Me.British_Standard_Bulb_flange_breadth.Visible = False
        '
        'British_Standard_Bulb_Web_thickness
        '
        Me.British_Standard_Bulb_Web_thickness.ItemHeight = 16
        Me.British_Standard_Bulb_Web_thickness.Items.AddRange(New Object() {"6", "7", "8", "6.5", "7", "8", "10", "7", "8", "9", "11.5", "8", "9", "10", "11.5", "8.5", "9", "10", "11", "12", "9", "10", "11", "12", "9.5", "10", "11", "12", "10", "11", "12", "10.5", "11", "12", "13", "11", "12", "13", "11.5", "12", "13", "14", "12", "13", "14", "15", "12.5", "13", "14", "15", "16", "13", "14", "15", "16", "14", "15", "17", "20"})
        Me.British_Standard_Bulb_Web_thickness.Location = New System.Drawing.Point(176, 220)
        Me.British_Standard_Bulb_Web_thickness.Name = "British_Standard_Bulb_Web_thickness"
        Me.British_Standard_Bulb_Web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_Web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_Web_thickness.TabIndex = 5
        Me.British_Standard_Bulb_Web_thickness.Visible = False
        '
        'British_Standard_Bulb_Web_Depth
        '
        Me.British_Standard_Bulb_Web_Depth.ItemHeight = 16
        Me.British_Standard_Bulb_Web_Depth.Items.AddRange(New Object() {"120", "120", "120", "140", "140", "140", "140", "160", "160", "160", "160", "180", "180", "180", "180", "200", "200", "200", "200", "200", "220", "220", "220", "220", "240", "240", "240", "240", "260", "260", "260", "280", "280", "280", "280", "300", "300", "300", "320", "320", "320", "320", "340", "340", "340", "340", "370", "370", "370", "370", "370", "400", "400", "400", "400", "430", "430", "430", "430"})
        Me.British_Standard_Bulb_Web_Depth.Location = New System.Drawing.Point(176, 196)
        Me.British_Standard_Bulb_Web_Depth.Name = "British_Standard_Bulb_Web_Depth"
        Me.British_Standard_Bulb_Web_Depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_Web_Depth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_Bulb_Web_Depth.TabIndex = 3
        Me.British_Standard_Bulb_Web_Depth.Visible = False
        '
        'Label_title06
        '
        Me.Label_title06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title06.Location = New System.Drawing.Point(8, 21)
        Me.Label_title06.Name = "Label_title06"
        Me.Label_title06.Size = New System.Drawing.Size(200, 20)
        Me.Label_title06.TabIndex = 1
        Me.Label_title06.Text = "שם החיזוק לפי התקן"
        '
        'British_Standard_Bulb_names
        '
        Me.British_Standard_Bulb_names.ItemHeight = 16
        Me.British_Standard_Bulb_names.Items.AddRange(New Object() {"120x6", "120x7", "120x8", "140x6.5", "140x7", "140x8", "140x10", "160x7", "160x8", "160x9", "160x11.5", "180x8", "180x9", "180x10", "180x11.5", "200x8.5", "200x9", "200x10", "200x11", "200x12", "220x9", "220x10", "220x11", "220x12", "240x9.5", "240x10", "240x11", "240x12", "260x10", "260x11", "260x12", "280x10.5", "280x11", "280x12", "280x13", "300x11", "300x12", "300x13", "320x11.5", "320x12", "320x13", "320x14", "340x12", "340x13", "340x14", "340x15", "370x12.5", "370x13", "370x14", "370x15", "370x16", "400x13", "400x14", "400x15", "400x16", "430x14", "430x15", "430x17", "430x20"})
        Me.British_Standard_Bulb_names.Location = New System.Drawing.Point(15, 46)
        Me.British_Standard_Bulb_names.Name = "British_Standard_Bulb_names"
        Me.British_Standard_Bulb_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_Bulb_names.Size = New System.Drawing.Size(189, 276)
        Me.British_Standard_Bulb_names.TabIndex = 0
        '
        'British_Standard_Bulb_pic_box
        '
        Me.British_Standard_Bulb_pic_box.Controls.Add(Me.bulb_radius_label)
        Me.British_Standard_Bulb_pic_box.Controls.Add(Me.web_depth_label)
        Me.British_Standard_Bulb_pic_box.Controls.Add(Me.British_Standard_Bulb_pic01)
        Me.British_Standard_Bulb_pic_box.Controls.Add(Me.Flange_breadth_label)
        Me.British_Standard_Bulb_pic_box.Controls.Add(Me.web_thickness_label)
        Me.British_Standard_Bulb_pic_box.Location = New System.Drawing.Point(580, 40)
        Me.British_Standard_Bulb_pic_box.Name = "British_Standard_Bulb_pic_box"
        Me.British_Standard_Bulb_pic_box.Size = New System.Drawing.Size(276, 280)
        Me.British_Standard_Bulb_pic_box.TabIndex = 22
        Me.British_Standard_Bulb_pic_box.TabStop = False
        Me.British_Standard_Bulb_pic_box.Text = "Profile: British Standard Bulb (Corus)"
        '
        'bulb_radius_label
        '
        Me.bulb_radius_label.AutoEllipsis = True
        Me.bulb_radius_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb_radius_label.Location = New System.Drawing.Point(183, 56)
        Me.bulb_radius_label.Name = "bulb_radius_label"
        Me.bulb_radius_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb_radius_label.Size = New System.Drawing.Size(64, 20)
        Me.bulb_radius_label.TabIndex = 13
        '
        'web_depth_label
        '
        Me.web_depth_label.AutoEllipsis = True
        Me.web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.web_depth_label.Location = New System.Drawing.Point(23, 124)
        Me.web_depth_label.Name = "web_depth_label"
        Me.web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.web_depth_label.Size = New System.Drawing.Size(72, 19)
        Me.web_depth_label.TabIndex = 11
        '
        'British_Standard_Bulb_pic01
        '
        Me.British_Standard_Bulb_pic01.Image = CType(resources.GetObject("British_Standard_Bulb_pic01.Image"), System.Drawing.Image)
        Me.British_Standard_Bulb_pic01.Location = New System.Drawing.Point(100, 50)
        Me.British_Standard_Bulb_pic01.Name = "British_Standard_Bulb_pic01"
        Me.British_Standard_Bulb_pic01.Size = New System.Drawing.Size(80, 172)
        Me.British_Standard_Bulb_pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.British_Standard_Bulb_pic01.TabIndex = 2
        Me.British_Standard_Bulb_pic01.TabStop = False
        '
        'Flange_breadth_label
        '
        Me.Flange_breadth_label.AutoEllipsis = True
        Me.Flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.Flange_breadth_label.Location = New System.Drawing.Point(90, 24)
        Me.Flange_breadth_label.Name = "Flange_breadth_label"
        Me.Flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Flange_breadth_label.Size = New System.Drawing.Size(82, 21)
        Me.Flange_breadth_label.TabIndex = 14
        Me.Flange_breadth_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'web_thickness_label
        '
        Me.web_thickness_label.AutoEllipsis = True
        Me.web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.web_thickness_label.Location = New System.Drawing.Point(96, 228)
        Me.web_thickness_label.Name = "web_thickness_label"
        Me.web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.web_thickness_label.Size = New System.Drawing.Size(72, 19)
        Me.web_thickness_label.TabIndex = 12
        '
        'British_Standard_EA_names
        '
        Me.British_Standard_EA_names.ItemHeight = 16
        Me.British_Standard_EA_names.Items.AddRange(New Object() {"25x25x3+", "25x25x4+", "25x25x5+", "30x30x3+", "30x30x4+", "30x30x5+", "40x40x3+", "40x40x4+", "40x40x5+", "40x40x6+", "45x45x3+", "45x45x4+", "45x45x5+", "45x45x6+", "50x50x3+", "50x50x4+", "50x50x5+", "50x50x6+", "50x50x8+", "60x60x5+", "60x60x6+", "60x60x8+", "60x60x10+", "70x70x6+", "70x70x8+", "70x70x10+", "80x80x6+", "80x80x8+", "80x80x10+", "90x90x6", "90x90x7", "90x90x8", "90x90x10", "90x90x12", "100x100x8", "100x100x10", "100x100x12", "100x100x15", "120x120x8", "120x120x10", "120x120x12", "120x120x15", "150x150x10", "150x150x12", "150x150x15", "150x150x18", "200x200x16", "200x200x18", "200x200x20", "200x200x24"})
        Me.British_Standard_EA_names.Location = New System.Drawing.Point(15, 46)
        Me.British_Standard_EA_names.Name = "British_Standard_EA_names"
        Me.British_Standard_EA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_names.Size = New System.Drawing.Size(189, 276)
        Me.British_Standard_EA_names.TabIndex = 16
        '
        'British_Standard_EA_profile_depth
        '
        Me.British_Standard_EA_profile_depth.ItemHeight = 16
        Me.British_Standard_EA_profile_depth.Items.AddRange(New Object() {"25", "25", "25", "30", "30", "30", "40", "40", "40", "40", "45", "45", "45", "45", "50", "50", "50", "50", "50", "60", "60", "60", "60", "70", "70", "70", "80", "80", "80", "90", "90", "90", "90", "90", "100", "100", "100", "100", "120", "120", "120", "120", "150", "150", "150", "150", "200", "200", "200", "200"})
        Me.British_Standard_EA_profile_depth.Location = New System.Drawing.Point(148, 184)
        Me.British_Standard_EA_profile_depth.Name = "British_Standard_EA_profile_depth"
        Me.British_Standard_EA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_profile_depth.TabIndex = 17
        Me.British_Standard_EA_profile_depth.Visible = False
        '
        'British_Standard_EA_web_depth
        '
        Me.British_Standard_EA_web_depth.ItemHeight = 16
        Me.British_Standard_EA_web_depth.Items.AddRange(New Object() {"22", "21", "20", "27", "26", "25", "37", "36", "35", "34", "42", "41", "40", "39", "47", "46", "45", "44", "42", "55", "54", "52", "50", "64", "62", "60", "74", "72", "70", "84", "83", "82", "80", "78", "92", "90", "88", "85", "112", "110", "108", "105", "140", "138", "135", "132", "184", "182", "180", "176"})
        Me.British_Standard_EA_web_depth.Location = New System.Drawing.Point(148, 208)
        Me.British_Standard_EA_web_depth.Name = "British_Standard_EA_web_depth"
        Me.British_Standard_EA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_web_depth.TabIndex = 18
        Me.British_Standard_EA_web_depth.Visible = False
        '
        'British_Standard_EA_web_thickness
        '
        Me.British_Standard_EA_web_thickness.ItemHeight = 16
        Me.British_Standard_EA_web_thickness.Items.AddRange(New Object() {"3", "4", "5", "3", "4", "5", "3", "4", "5", "6", "3", "4", "5", "6", "3", "4", "5", "6", "8", "5", "6", "8", "10", "6", "8", "10", "6", "8", "10", "6", "7", "8", "10", "12", "8", "10", "12", "15", "8", "10", "12", "15", "10", "12", "15", "18", "16", "18", "20", "24"})
        Me.British_Standard_EA_web_thickness.Location = New System.Drawing.Point(148, 232)
        Me.British_Standard_EA_web_thickness.Name = "British_Standard_EA_web_thickness"
        Me.British_Standard_EA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_web_thickness.TabIndex = 19
        Me.British_Standard_EA_web_thickness.Visible = False
        '
        'British_Standard_EA_flange_breadth
        '
        Me.British_Standard_EA_flange_breadth.ItemHeight = 16
        Me.British_Standard_EA_flange_breadth.Items.AddRange(New Object() {"25", "25", "25", "30", "30", "30", "40", "40", "40", "40", "45", "45", "45", "45", "50", "50", "50", "50", "50", "60", "60", "60", "60", "70", "70", "70", "80", "80", "80", "90", "90", "90", "90", "90", "100", "100", "100", "100", "120", "120", "120", "120", "150", "150", "150", "150", "200", "200", "200", "200"})
        Me.British_Standard_EA_flange_breadth.Location = New System.Drawing.Point(148, 256)
        Me.British_Standard_EA_flange_breadth.Name = "British_Standard_EA_flange_breadth"
        Me.British_Standard_EA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_flange_breadth.TabIndex = 20
        Me.British_Standard_EA_flange_breadth.Visible = False
        '
        'British_Standard_EA_flange_thickness
        '
        Me.British_Standard_EA_flange_thickness.ItemHeight = 16
        Me.British_Standard_EA_flange_thickness.Items.AddRange(New Object() {"3", "4", "5", "3", "4", "5", "3", "4", "5", "6", "3", "4", "5", "6", "3", "4", "5", "6", "8", "5", "6", "8", "10", "6", "8", "10", "6", "8", "10", "6", "7", "8", "10", "12", "8", "10", "12", "15", "8", "10", "12", "15", "10", "12", "15", "18", "16", "18", "20", "24"})
        Me.British_Standard_EA_flange_thickness.Location = New System.Drawing.Point(148, 280)
        Me.British_Standard_EA_flange_thickness.Name = "British_Standard_EA_flange_thickness"
        Me.British_Standard_EA_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_flange_thickness.TabIndex = 21
        Me.British_Standard_EA_flange_thickness.Visible = False
        '
        'British_Standard_EA_pic_box
        '
        Me.British_Standard_EA_pic_box.Controls.Add(Me.British_Standard_EA_flange_thickness_label)
        Me.British_Standard_EA_pic_box.Controls.Add(Me.British_Standard_EA_flange_breadth_label)
        Me.British_Standard_EA_pic_box.Controls.Add(Me.British_Standard_EA_profile_depth_label)
        Me.British_Standard_EA_pic_box.Controls.Add(Me.British_Standard_EA_web_depth_label)
        Me.British_Standard_EA_pic_box.Controls.Add(Me.British_Standard_EA_web_thickness_label)
        Me.British_Standard_EA_pic_box.Controls.Add(Me.PictureBox1)
        Me.British_Standard_EA_pic_box.Location = New System.Drawing.Point(580, 40)
        Me.British_Standard_EA_pic_box.Name = "British_Standard_EA_pic_box"
        Me.British_Standard_EA_pic_box.Size = New System.Drawing.Size(276, 280)
        Me.British_Standard_EA_pic_box.TabIndex = 23
        Me.British_Standard_EA_pic_box.TabStop = False
        Me.British_Standard_EA_pic_box.Text = "Profile: British Standard EA (Corus)"
        '
        'British_Standard_EA_flange_thickness_label
        '
        Me.British_Standard_EA_flange_thickness_label.AutoEllipsis = True
        Me.British_Standard_EA_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_EA_flange_thickness_label.Location = New System.Drawing.Point(12, 60)
        Me.British_Standard_EA_flange_thickness_label.Name = "British_Standard_EA_flange_thickness_label"
        Me.British_Standard_EA_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_flange_thickness_label.Size = New System.Drawing.Size(60, 21)
        Me.British_Standard_EA_flange_thickness_label.TabIndex = 15
        '
        'British_Standard_EA_flange_breadth_label
        '
        Me.British_Standard_EA_flange_breadth_label.AutoEllipsis = True
        Me.British_Standard_EA_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_EA_flange_breadth_label.Location = New System.Drawing.Point(116, 20)
        Me.British_Standard_EA_flange_breadth_label.Name = "British_Standard_EA_flange_breadth_label"
        Me.British_Standard_EA_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_flange_breadth_label.Size = New System.Drawing.Size(72, 20)
        Me.British_Standard_EA_flange_breadth_label.TabIndex = 14
        '
        'British_Standard_EA_profile_depth_label
        '
        Me.British_Standard_EA_profile_depth_label.AutoEllipsis = True
        Me.British_Standard_EA_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_EA_profile_depth_label.Location = New System.Drawing.Point(148, 127)
        Me.British_Standard_EA_profile_depth_label.Name = "British_Standard_EA_profile_depth_label"
        Me.British_Standard_EA_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_profile_depth_label.Size = New System.Drawing.Size(77, 21)
        Me.British_Standard_EA_profile_depth_label.TabIndex = 13
        Me.British_Standard_EA_profile_depth_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'British_Standard_EA_web_depth_label
        '
        Me.British_Standard_EA_web_depth_label.AutoEllipsis = True
        Me.British_Standard_EA_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_EA_web_depth_label.Location = New System.Drawing.Point(12, 128)
        Me.British_Standard_EA_web_depth_label.Name = "British_Standard_EA_web_depth_label"
        Me.British_Standard_EA_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_web_depth_label.Size = New System.Drawing.Size(60, 20)
        Me.British_Standard_EA_web_depth_label.TabIndex = 12
        '
        'British_Standard_EA_web_thickness_label
        '
        Me.British_Standard_EA_web_thickness_label.AutoEllipsis = True
        Me.British_Standard_EA_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_EA_web_thickness_label.Location = New System.Drawing.Point(58, 215)
        Me.British_Standard_EA_web_thickness_label.Name = "British_Standard_EA_web_thickness_label"
        Me.British_Standard_EA_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_web_thickness_label.Size = New System.Drawing.Size(69, 20)
        Me.British_Standard_EA_web_thickness_label.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(73, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'British_Standard_EA_corus
        '
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_A_box)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_y_box)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_ix_box)
        Me.British_Standard_EA_corus.Controls.Add(Me.Label_title05)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_flange_thickness)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_web_thickness)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_web_depth)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_flange_breadth)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_profile_depth)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_pic_box)
        Me.British_Standard_EA_corus.Controls.Add(Me.box05)
        Me.British_Standard_EA_corus.Controls.Add(Me.British_Standard_EA_names)
        Me.British_Standard_EA_corus.Location = New System.Drawing.Point(6, 12)
        Me.British_Standard_EA_corus.Name = "British_Standard_EA_corus"
        Me.British_Standard_EA_corus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_corus.Size = New System.Drawing.Size(868, 356)
        Me.British_Standard_EA_corus.TabIndex = 3
        Me.British_Standard_EA_corus.TabStop = False
        Me.British_Standard_EA_corus.Text = "British Standard EA (Corus)"
        Me.British_Standard_EA_corus.Visible = False
        '
        'British_Standard_EA_A_box
        '
        Me.British_Standard_EA_A_box.ItemHeight = 16
        Me.British_Standard_EA_A_box.Items.AddRange(New Object() {"1.57", "2", "2.41", "1.87", "2.4", "2.91", "2.47", "3.2", "3.91", "4.6", "2.77", "3.6", "4.41", "5.2", "3.07", "4", "4.91", "5.8", "7.52", "5.91", "7", "9.12", "11.2", "8.2", "10.7", "13.2", "9.4", "12.3", "15.2", "10.6", "12.3", "13.9", "17.2", "20.3", "15.6", "19.2", "22.8", "28", "18.8", "23.3", "27.6", "34", "29.5", "35", "43.2", "51.2", "62", "69.4", "76.6", "90.8"})
        Me.British_Standard_EA_A_box.Location = New System.Drawing.Point(220, 272)
        Me.British_Standard_EA_A_box.Name = "British_Standard_EA_A_box"
        Me.British_Standard_EA_A_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_A_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_A_box.TabIndex = 28
        Me.British_Standard_EA_A_box.Visible = False
        '
        'British_Standard_EA_y_box
        '
        Me.British_Standard_EA_y_box.ItemHeight = 16
        Me.British_Standard_EA_y_box.Items.AddRange(New Object() {"1.83", "1.77", "1.72", "2.22", "2.16", "2.11", "2.99", "2.92", "2.87", "2.82", "3.37", "3.3", "3.25", "3.2", "3.75", "3.68", "3.63", "3.58", "3.49", "4.38", "4.33", "4.24", "4.16", "5.08", "5", "4.92", "5.84", "5.75", "5.67", "6.59", "6.54", "6.5", "6.42", "6.34", "7.25", "7.17", "7.09", "6.98", "8.76", "8.68", "8.59", "8.48", "10.94", "10.86", "10.74", "10.62", "14.46", "14.38", "14.3", "14.15"})
        Me.British_Standard_EA_y_box.Location = New System.Drawing.Point(220, 228)
        Me.British_Standard_EA_y_box.Name = "British_Standard_EA_y_box"
        Me.British_Standard_EA_y_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_y_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_y_box.TabIndex = 27
        Me.British_Standard_EA_y_box.Visible = False
        '
        'British_Standard_EA_ix_box
        '
        Me.British_Standard_EA_ix_box.ItemHeight = 16
        Me.British_Standard_EA_ix_box.Items.AddRange(New Object() {"0.672", "0.894", "1.09", "1.25", "1.65", "2.02", "3.22", "4.25", "5.21", "6.1", "4.71", "6.22", "7.63", "8.95", "6.6", "8.72", "10.7", "12.6", "16", "19.2", "22.6", "28.9", "34.7", "36.8", "47.4", "57.1", "56", "72.4", "87.7", "81", "93.2", "105", "128", "149", "146", "178", "208", "250", "259", "316", "371", "448", "635", "748", "909", "1060", "2369", "2627", "2877", "3356"})
        Me.British_Standard_EA_ix_box.Location = New System.Drawing.Point(220, 188)
        Me.British_Standard_EA_ix_box.Name = "British_Standard_EA_ix_box"
        Me.British_Standard_EA_ix_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_EA_ix_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_EA_ix_box.TabIndex = 26
        Me.British_Standard_EA_ix_box.Visible = False
        '
        'Label_title05
        '
        Me.Label_title05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title05.Location = New System.Drawing.Point(12, 20)
        Me.Label_title05.Name = "Label_title05"
        Me.Label_title05.Size = New System.Drawing.Size(196, 20)
        Me.Label_title05.TabIndex = 24
        Me.Label_title05.Text = "שם החיזוק לפי התקן"
        '
        'box05
        '
        Me.box05.Controls.Add(Me.label_y05_unit)
        Me.box05.Controls.Add(Me.textbox_y05)
        Me.box05.Controls.Add(Me.label_a05_unit)
        Me.box05.Controls.Add(Me.textbox_a05)
        Me.box05.Controls.Add(Me.label_m05_unit)
        Me.box05.Controls.Add(Me.textbox_m05)
        Me.box05.Controls.Add(Me.label_y05)
        Me.box05.Controls.Add(Me.label_a05)
        Me.box05.Controls.Add(Me.label_m05)
        Me.box05.Font = New System.Drawing.Font("David", 10.8!)
        Me.box05.Location = New System.Drawing.Point(207, 38)
        Me.box05.Name = "box05"
        Me.box05.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box05.Size = New System.Drawing.Size(364, 136)
        Me.box05.TabIndex = 25
        Me.box05.TabStop = False
        Me.box05.Text = "נתוני החיזוק"
        '
        'label_y05_unit
        '
        Me.label_y05_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y05_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y05_unit.Name = "label_y05_unit"
        Me.label_y05_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y05_unit.TabIndex = 8
        Me.label_y05_unit.Text = "[cm]"
        '
        'textbox_y05
        '
        Me.textbox_y05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y05.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y05.Name = "textbox_y05"
        Me.textbox_y05.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y05.TabIndex = 7
        '
        'label_a05_unit
        '
        Me.label_a05_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a05_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a05_unit.Name = "label_a05_unit"
        Me.label_a05_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a05_unit.TabIndex = 6
        Me.label_a05_unit.Text = "[cm^2]"
        '
        'textbox_a05
        '
        Me.textbox_a05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a05.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a05.Name = "textbox_a05"
        Me.textbox_a05.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a05.TabIndex = 5
        '
        'label_m05_unit
        '
        Me.label_m05_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m05_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m05_unit.Name = "label_m05_unit"
        Me.label_m05_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m05_unit.TabIndex = 4
        Me.label_m05_unit.Text = "[cm^4]"
        '
        'textbox_m05
        '
        Me.textbox_m05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m05.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m05.Name = "textbox_m05"
        Me.textbox_m05.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m05.TabIndex = 3
        '
        'label_y05
        '
        Me.label_y05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y05.Location = New System.Drawing.Point(188, 94)
        Me.label_y05.Name = "label_y05"
        Me.label_y05.Size = New System.Drawing.Size(164, 24)
        Me.label_y05.TabIndex = 2
        Me.label_y05.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a05
        '
        Me.label_a05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a05.Location = New System.Drawing.Point(188, 63)
        Me.label_a05.Name = "label_a05"
        Me.label_a05.Size = New System.Drawing.Size(164, 24)
        Me.label_a05.TabIndex = 1
        Me.label_a05.Text = "שטח חתך החיזוק"
        '
        'label_m05
        '
        Me.label_m05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m05.Location = New System.Drawing.Point(188, 32)
        Me.label_m05.Name = "label_m05"
        Me.label_m05.Size = New System.Drawing.Size(164, 24)
        Me.label_m05.TabIndex = 0
        Me.label_m05.Text = "מומנט אינרציה (Ix)"
        '
        'British_Standard_UEA_corus
        '
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_a_box)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_y_box)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_I_box)
        Me.British_Standard_UEA_corus.Controls.Add(Me.Label_title04)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_flange_thickness)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_web_thickness)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_web_depth)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_flange_breadth)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_profile_depth)
        Me.British_Standard_UEA_corus.Controls.Add(Me.box04)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_names)
        Me.British_Standard_UEA_corus.Controls.Add(Me.British_Standard_UEA_corus_groupbox)
        Me.British_Standard_UEA_corus.Location = New System.Drawing.Point(6, 12)
        Me.British_Standard_UEA_corus.Name = "British_Standard_UEA_corus"
        Me.British_Standard_UEA_corus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_corus.Size = New System.Drawing.Size(868, 356)
        Me.British_Standard_UEA_corus.TabIndex = 4
        Me.British_Standard_UEA_corus.TabStop = False
        Me.British_Standard_UEA_corus.Text = "British Standard UEA (Corus)"
        Me.British_Standard_UEA_corus.Visible = False
        '
        'British_Standard_UEA_a_box
        '
        Me.British_Standard_UEA_a_box.ItemHeight = 16
        Me.British_Standard_UEA_a_box.Items.AddRange(New Object() {"2.45", "4.3", "5.09", "5.55", "6.59", "8.61", "7.22", "9.44", "8.08", "9.35", "10.6", "11.2", "12.7", "15.6", "13.5", "16.6", "19.7", "15.5", "19.2", "22.7", "21.7", "25.7", "31.7", "23.2", "27.6", "34", "29.4", "34.9", "43.1", "40.9", "50.6", "60.1"})
        Me.British_Standard_UEA_a_box.Location = New System.Drawing.Point(312, 248)
        Me.British_Standard_UEA_a_box.Name = "British_Standard_UEA_a_box"
        Me.British_Standard_UEA_a_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_a_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_a_box.TabIndex = 28
        Me.British_Standard_UEA_a_box.Visible = False
        '
        'British_Standard_UEA_y_box
        '
        Me.British_Standard_UEA_y_box.ItemHeight = 16
        Me.British_Standard_UEA_y_box.Items.AddRange(New Object() {"3.38", "5.32", "5.28", "5.24", "5.2", "5.13", "6.29", "6.21", "6.52", "6.48", "6.44", "8.49", "8.44", "8.37", "8.13", "8.05", "7.97", "10.82", "10.74", "10.66", "13.38", "13.3", "13.19", "12.96", "12.88", "12.76", "17.97", "17.89", "17.77", "16.37", "16.25", "16.14"})
        Me.British_Standard_UEA_y_box.Location = New System.Drawing.Point(312, 220)
        Me.British_Standard_UEA_y_box.Name = "British_Standard_UEA_y_box"
        Me.British_Standard_UEA_y_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_y_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_y_box.TabIndex = 27
        Me.British_Standard_UEA_y_box.Visible = False
        '
        'British_Standard_UEA_I_box
        '
        Me.British_Standard_UEA_I_box.ItemHeight = 16
        Me.British_Standard_UEA_I_box.Items.AddRange(New Object() {"3.86", "15.7", "18.3", "23.3", "27.4", "34.9", "40.9", "52.4", "50.9", "58.5", "65.8", "113", "127", "154", "133", "162", "189", "249", "303", "355", "503", "591", "715", "536", "630", "764", "1233", "1454", "1772", "1667", "2037", "2390"})
        Me.British_Standard_UEA_I_box.Location = New System.Drawing.Point(312, 196)
        Me.British_Standard_UEA_I_box.Name = "British_Standard_UEA_I_box"
        Me.British_Standard_UEA_I_box.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_I_box.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_I_box.TabIndex = 26
        Me.British_Standard_UEA_I_box.Visible = False
        '
        'Label_title04
        '
        Me.Label_title04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title04.Location = New System.Drawing.Point(12, 20)
        Me.Label_title04.Name = "Label_title04"
        Me.Label_title04.Size = New System.Drawing.Size(192, 20)
        Me.Label_title04.TabIndex = 24
        Me.Label_title04.Text = "שם החיזוק לפי התקן"
        '
        'British_Standard_UEA_flange_thickness
        '
        Me.British_Standard_UEA_flange_thickness.ItemHeight = 16
        Me.British_Standard_UEA_flange_thickness.Items.AddRange(New Object() {"4", "5", "6", "5", "6", "8", "6", "8", "6", "7", "8", "7", "8", "10", "8", "10", "12", "8", "10", "12", "10", "12", "15", "10", "12", "15", "10", "12", "15", "12", "15", "18"})
        Me.British_Standard_UEA_flange_thickness.Location = New System.Drawing.Point(220, 180)
        Me.British_Standard_UEA_flange_thickness.Name = "British_Standard_UEA_flange_thickness"
        Me.British_Standard_UEA_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_flange_thickness.TabIndex = 21
        Me.British_Standard_UEA_flange_thickness.Visible = False
        '
        'British_Standard_UEA_web_thickness
        '
        Me.British_Standard_UEA_web_thickness.ItemHeight = 16
        Me.British_Standard_UEA_web_thickness.Items.AddRange(New Object() {"4", "5", "6", "5", "6", "8", "6", "8", "6", "7", "8", "7", "8", "10", "8", "10", "12", "8", "10", "12", "10", "12", "15", "10", "12", "15", "10", "12", "15", "12", "15", "18"})
        Me.British_Standard_UEA_web_thickness.Location = New System.Drawing.Point(152, 228)
        Me.British_Standard_UEA_web_thickness.Name = "British_Standard_UEA_web_thickness"
        Me.British_Standard_UEA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_web_thickness.TabIndex = 19
        Me.British_Standard_UEA_web_thickness.Visible = False
        '
        'British_Standard_UEA_web_depth
        '
        Me.British_Standard_UEA_web_depth.ItemHeight = 16
        Me.British_Standard_UEA_web_depth.Items.AddRange(New Object() {"36", "55", "54", "60", "59", "57", "69", "67", "74", "73", "72", "93", "92", "90", "92", "90", "88", "117", "115", "113", "140", "138", "135", "140", "138", "135", "190", "188", "185", "188", "185", "182"})
        Me.British_Standard_UEA_web_depth.Location = New System.Drawing.Point(152, 204)
        Me.British_Standard_UEA_web_depth.Name = "British_Standard_UEA_web_depth"
        Me.British_Standard_UEA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_web_depth.TabIndex = 18
        Me.British_Standard_UEA_web_depth.Visible = False
        '
        'British_Standard_UEA_flange_breadth
        '
        Me.British_Standard_UEA_flange_breadth.ItemHeight = 16
        Me.British_Standard_UEA_flange_breadth.Items.AddRange(New Object() {"25", "30", "30", "50", "50", "50", "50", "50", "60", "60", "60", "65", "65", "65", "75", "75", "75", "75", "75", "75", "75", "75", "75", "90", "90", "90", "100", "100", "100", "150", "150", "150"})
        Me.British_Standard_UEA_flange_breadth.Location = New System.Drawing.Point(152, 252)
        Me.British_Standard_UEA_flange_breadth.Name = "British_Standard_UEA_flange_breadth"
        Me.British_Standard_UEA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_flange_breadth.TabIndex = 20
        Me.British_Standard_UEA_flange_breadth.Visible = False
        '
        'British_Standard_UEA_profile_depth
        '
        Me.British_Standard_UEA_profile_depth.ItemHeight = 16
        Me.British_Standard_UEA_profile_depth.Items.AddRange(New Object() {"40", "60", "60", "65", "65", "65", "75", "75", "80", "80", "80", "100", "100", "100", "100", "100", "100", "125", "125", "125", "150", "150", "150", "150", "150", "150", "200", "200", "200", "200", "200", "200"})
        Me.British_Standard_UEA_profile_depth.Location = New System.Drawing.Point(152, 180)
        Me.British_Standard_UEA_profile_depth.Name = "British_Standard_UEA_profile_depth"
        Me.British_Standard_UEA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_profile_depth.TabIndex = 17
        Me.British_Standard_UEA_profile_depth.Visible = False
        '
        'British_Standard_UEA_corus_groupbox
        '
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.British_Standard_UEA_flange_thickness_label)
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.British_Standard_UEA_flange_breadth_label)
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.British_Standard_UEA_Profile_depth_label)
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.British_Standard_UEA_web_depth_label)
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.British_Standard_UEA_web_thickness_label)
        Me.British_Standard_UEA_corus_groupbox.Controls.Add(Me.PictureBox2)
        Me.British_Standard_UEA_corus_groupbox.Location = New System.Drawing.Point(580, 40)
        Me.British_Standard_UEA_corus_groupbox.Name = "British_Standard_UEA_corus_groupbox"
        Me.British_Standard_UEA_corus_groupbox.Size = New System.Drawing.Size(276, 280)
        Me.British_Standard_UEA_corus_groupbox.TabIndex = 23
        Me.British_Standard_UEA_corus_groupbox.TabStop = False
        Me.British_Standard_UEA_corus_groupbox.Text = "Profile: British Standard UEA (Corus)"
        '
        'British_Standard_UEA_flange_thickness_label
        '
        Me.British_Standard_UEA_flange_thickness_label.AutoEllipsis = True
        Me.British_Standard_UEA_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_UEA_flange_thickness_label.Location = New System.Drawing.Point(9, 59)
        Me.British_Standard_UEA_flange_thickness_label.Name = "British_Standard_UEA_flange_thickness_label"
        Me.British_Standard_UEA_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_flange_thickness_label.Size = New System.Drawing.Size(65, 25)
        Me.British_Standard_UEA_flange_thickness_label.TabIndex = 15
        '
        'British_Standard_UEA_flange_breadth_label
        '
        Me.British_Standard_UEA_flange_breadth_label.AutoEllipsis = True
        Me.British_Standard_UEA_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_UEA_flange_breadth_label.Location = New System.Drawing.Point(127, 20)
        Me.British_Standard_UEA_flange_breadth_label.Name = "British_Standard_UEA_flange_breadth_label"
        Me.British_Standard_UEA_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_flange_breadth_label.Size = New System.Drawing.Size(72, 21)
        Me.British_Standard_UEA_flange_breadth_label.TabIndex = 14
        '
        'British_Standard_UEA_Profile_depth_label
        '
        Me.British_Standard_UEA_Profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_UEA_Profile_depth_label.Location = New System.Drawing.Point(146, 112)
        Me.British_Standard_UEA_Profile_depth_label.Name = "British_Standard_UEA_Profile_depth_label"
        Me.British_Standard_UEA_Profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_Profile_depth_label.Size = New System.Drawing.Size(76, 21)
        Me.British_Standard_UEA_Profile_depth_label.TabIndex = 13
        '
        'British_Standard_UEA_web_depth_label
        '
        Me.British_Standard_UEA_web_depth_label.AutoEllipsis = True
        Me.British_Standard_UEA_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_UEA_web_depth_label.Location = New System.Drawing.Point(9, 116)
        Me.British_Standard_UEA_web_depth_label.Name = "British_Standard_UEA_web_depth_label"
        Me.British_Standard_UEA_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_web_depth_label.Size = New System.Drawing.Size(65, 28)
        Me.British_Standard_UEA_web_depth_label.TabIndex = 12
        '
        'British_Standard_UEA_web_thickness_label
        '
        Me.British_Standard_UEA_web_thickness_label.AutoEllipsis = True
        Me.British_Standard_UEA_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.British_Standard_UEA_web_thickness_label.Location = New System.Drawing.Point(72, 212)
        Me.British_Standard_UEA_web_thickness_label.Name = "British_Standard_UEA_web_thickness_label"
        Me.British_Standard_UEA_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_web_thickness_label.Size = New System.Drawing.Size(64, 20)
        Me.British_Standard_UEA_web_thickness_label.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(80, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'box04
        '
        Me.box04.Controls.Add(Me.label_y04_unit)
        Me.box04.Controls.Add(Me.textbox_a04)
        Me.box04.Controls.Add(Me.label_a04_unit)
        Me.box04.Controls.Add(Me.textbox_y04)
        Me.box04.Controls.Add(Me.label_m04_unit)
        Me.box04.Controls.Add(Me.textbox_m04)
        Me.box04.Controls.Add(Me.label_y04)
        Me.box04.Controls.Add(Me.label_a04)
        Me.box04.Controls.Add(Me.label_m04)
        Me.box04.Font = New System.Drawing.Font("David", 10.8!)
        Me.box04.Location = New System.Drawing.Point(207, 38)
        Me.box04.Name = "box04"
        Me.box04.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box04.Size = New System.Drawing.Size(364, 136)
        Me.box04.TabIndex = 25
        Me.box04.TabStop = False
        Me.box04.Text = "נתוני החיזוק"
        '
        'label_y04_unit
        '
        Me.label_y04_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y04_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y04_unit.Name = "label_y04_unit"
        Me.label_y04_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y04_unit.TabIndex = 8
        Me.label_y04_unit.Text = "[cm]"
        '
        'textbox_a04
        '
        Me.textbox_a04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a04.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a04.Name = "textbox_a04"
        Me.textbox_a04.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a04.TabIndex = 7
        '
        'label_a04_unit
        '
        Me.label_a04_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a04_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a04_unit.Name = "label_a04_unit"
        Me.label_a04_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a04_unit.TabIndex = 6
        Me.label_a04_unit.Text = "[cm^2]"
        '
        'textbox_y04
        '
        Me.textbox_y04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y04.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y04.Name = "textbox_y04"
        Me.textbox_y04.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y04.TabIndex = 5
        '
        'label_m04_unit
        '
        Me.label_m04_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m04_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m04_unit.Name = "label_m04_unit"
        Me.label_m04_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m04_unit.TabIndex = 4
        Me.label_m04_unit.Text = "[cm^4]"
        '
        'textbox_m04
        '
        Me.textbox_m04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m04.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m04.Name = "textbox_m04"
        Me.textbox_m04.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m04.TabIndex = 3
        '
        'label_y04
        '
        Me.label_y04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y04.Location = New System.Drawing.Point(188, 94)
        Me.label_y04.Name = "label_y04"
        Me.label_y04.Size = New System.Drawing.Size(164, 24)
        Me.label_y04.TabIndex = 2
        Me.label_y04.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a04
        '
        Me.label_a04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a04.Location = New System.Drawing.Point(188, 63)
        Me.label_a04.Name = "label_a04"
        Me.label_a04.Size = New System.Drawing.Size(164, 24)
        Me.label_a04.TabIndex = 1
        Me.label_a04.Text = "שטח חתך החיזוק"
        '
        'label_m04
        '
        Me.label_m04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m04.Location = New System.Drawing.Point(188, 32)
        Me.label_m04.Name = "label_m04"
        Me.label_m04.Size = New System.Drawing.Size(164, 24)
        Me.label_m04.TabIndex = 0
        Me.label_m04.Text = "מומנט אינרציה (Ix)"
        '
        'British_Standard_UEA_names
        '
        Me.British_Standard_UEA_names.ItemHeight = 16
        Me.British_Standard_UEA_names.Items.AddRange(New Object() {"40x25x4+", "60x30x5+", "60x30x6+", "65x50x5+", "65x50x6+", "65x50x8+", "75x50x6+", "75x50x8+", "80x60x6+", "80x60x7+", "80x60x8+", "100x65x7", "100x65x8", "100x65x10", "100x75x8", "100x75x10", "100x75x12", "125x75x8", "125x75x10", "125x75x12", "150x75x10", "150x75x12", "150x75x15", "150x90x10", "150x90x12", "150x90x15", "200x100x10", "200x100x12", "200x100x15", "200x150x12", "200x150x15", "200x150x18"})
        Me.British_Standard_UEA_names.Location = New System.Drawing.Point(15, 46)
        Me.British_Standard_UEA_names.Name = "British_Standard_UEA_names"
        Me.British_Standard_UEA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_names.Size = New System.Drawing.Size(189, 276)
        Me.British_Standard_UEA_names.TabIndex = 16
        '
        'FDA01
        '
        Me.FDA01.Controls.Add(Me.Standard_Blades_web_thickness)
        Me.FDA01.Controls.Add(Me.Standard_Blades_profiles_depth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_UIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_UIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.Polish_Standard_UIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_UIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_EIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_EIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.Polish_Standard_EIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.Polish_Standard_EIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.Korean_Standard_EIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.Korean_Standard_EIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.Korean_Standard_EIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.Korean_Standard_EIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.Japanese_Standard_EIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.Japanese_Standard_EIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.Japanese_Standard_EIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.Japanese_Standard_EIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_UIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_UIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.ISO_Standard_UIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_UIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_UIA_FDA_names)
        Me.FDA01.Controls.Add(Me.DIN_Standard_EIA_FDA_names)
        Me.FDA01.Controls.Add(Me.Label_title01)
        Me.FDA01.Controls.Add(Me.British_Standard_UEA_FDA_names)
        Me.FDA01.Controls.Add(Me.British_Standard_UEA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.British_Standard_UEA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.British_Standard_UEA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_EIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_EIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.ISO_Standard_EIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.ISO_Standard_EIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.European_Standard_UIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.European_Standard_UIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.European_Standard_UIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.European_Standard_UIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_UIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_UIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.DIN_Standard_UIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_UIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_EIA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_EIA_FDA_web_thickness)
        Me.FDA01.Controls.Add(Me.DIN_Standard_EIA_FDA_web_depth)
        Me.FDA01.Controls.Add(Me.DIN_Standard_EIA_FDA_profile_depth)
        Me.FDA01.Controls.Add(Me.British_Standard_UEA_FDA_flange_breadth)
        Me.FDA01.Controls.Add(Me.Standard_Blades_names)
        Me.FDA01.Controls.Add(Me.Polish_Standard_UIA_FDA_names)
        Me.FDA01.Controls.Add(Me.Polish_Standard_EIA_FDA_names)
        Me.FDA01.Controls.Add(Me.Korean_Standard_EIA_FDA_names)
        Me.FDA01.Controls.Add(Me.Japanese_Standard_EIA_FDA_names)
        Me.FDA01.Controls.Add(Me.ISO_Standard_UIA_FDA_names)
        Me.FDA01.Controls.Add(Me.box01)
        Me.FDA01.Controls.Add(Me.ISO_Standard_EIA_FDA_names)
        Me.FDA01.Controls.Add(Me.European_Standard_UIA_FDA_names)
        Me.FDA01.Controls.Add(Me.FDA01_pic)
        Me.FDA01.Controls.Add(Me.FDA01_blade_pic)
        Me.FDA01.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.FDA01.Location = New System.Drawing.Point(6, 12)
        Me.FDA01.Name = "FDA01"
        Me.FDA01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA01.Size = New System.Drawing.Size(868, 356)
        Me.FDA01.TabIndex = 5
        Me.FDA01.TabStop = False
        Me.FDA01.Text = "FDA01"
        Me.FDA01.Visible = False
        '
        'Standard_Blades_web_thickness
        '
        Me.Standard_Blades_web_thickness.ItemHeight = 16
        Me.Standard_Blades_web_thickness.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "12", "13", "14", "6", "7", "8", "9", "10", "11", "12", "12", "13", "14"})
        Me.Standard_Blades_web_thickness.Location = New System.Drawing.Point(560, 224)
        Me.Standard_Blades_web_thickness.Name = "Standard_Blades_web_thickness"
        Me.Standard_Blades_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Standard_Blades_web_thickness.Size = New System.Drawing.Size(32, 20)
        Me.Standard_Blades_web_thickness.TabIndex = 75
        Me.Standard_Blades_web_thickness.Visible = False
        '
        'Standard_Blades_profiles_depth
        '
        Me.Standard_Blades_profiles_depth.ItemHeight = 16
        Me.Standard_Blades_profiles_depth.Items.AddRange(New Object() {"50", "50", "50", "50", "50", "50", "50", "50", "50", "65", "65", "65", "65", "65", "65", "65", "65", "65", "65", "75", "75", "75", "75", "75", "75", "75", "75", "75", "90", "90", "90", "90", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "100", "100", "100", "100", "100", "125", "125", "125", "125", "125", "125", "125", "125", "125", "125", "150", "150", "150", "150", "150", "150", "150", "150", "150", "150"})
        Me.Standard_Blades_profiles_depth.Location = New System.Drawing.Point(560, 184)
        Me.Standard_Blades_profiles_depth.Name = "Standard_Blades_profiles_depth"
        Me.Standard_Blades_profiles_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Standard_Blades_profiles_depth.Size = New System.Drawing.Size(32, 20)
        Me.Standard_Blades_profiles_depth.TabIndex = 74
        Me.Standard_Blades_profiles_depth.Visible = False
        '
        'Polish_Standard_UIA_FDA_flange_breadth
        '
        Me.Polish_Standard_UIA_FDA_flange_breadth.ItemHeight = 16
        Me.Polish_Standard_UIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "20", "20", "20", "25", "30", "30", "30", "30", "30", "40", "40", "30", "40", "40", "40", "50", "50", "50", "50", "50", "50", "55", "55", "55", "40", "40", "60", "65", "65", "60", "60", "50", "50", "50", "65", "65", "65", "75", "75", "75", "80", "80", "80", "65", "65", "65", "90", "75", "75", "100", "100", "100", "80", "90", "90", "100", "100", "100"})
        Me.Polish_Standard_UIA_FDA_flange_breadth.Location = New System.Drawing.Point(336, 288)
        Me.Polish_Standard_UIA_FDA_flange_breadth.Name = "Polish_Standard_UIA_FDA_flange_breadth"
        Me.Polish_Standard_UIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_UIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_UIA_FDA_flange_breadth.TabIndex = 72
        Me.Polish_Standard_UIA_FDA_flange_breadth.Visible = False
        '
        'Polish_Standard_UIA_FDA_web_thickness
        '
        Me.Polish_Standard_UIA_FDA_web_thickness.ItemHeight = 16
        Me.Polish_Standard_UIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "4", "3", "4", "4", "3", "4", "5", "4", "5", "4", "5", "5", "5", "6", "7", "5", "7", "9", "6", "7", "9", "5", "7", "9", "6", "8", "7", "8", "10", "6", "8", "6", "8", "10", "7", "9", "11", "7", "9", "11", "8", "10", "12", "8", "10", "12", "12", "9", "11", "10", "12", "14", "12", "10", "12", "10", "12", "14"})
        Me.Polish_Standard_UIA_FDA_web_thickness.Location = New System.Drawing.Point(336, 264)
        Me.Polish_Standard_UIA_FDA_web_thickness.Name = "Polish_Standard_UIA_FDA_web_thickness"
        Me.Polish_Standard_UIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_UIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_UIA_FDA_web_thickness.TabIndex = 71
        Me.Polish_Standard_UIA_FDA_web_thickness.Visible = False
        '
        'Polish_Standard_UIA_FDA_web_depth
        '
        Me.Polish_Standard_UIA_FDA_web_depth.ItemHeight = 16
        Me.Polish_Standard_UIA_FDA_web_depth.Items.AddRange(New Object() {"27", "26", "37", "36", "36", "42", "41", "40", "46", "45", "46", "45", "55", "55", "54", "53", "60", "58", "56", "64", "68", "66", "70", "68", "66", "74", "72", "73", "72", "70", "84", "82", "94", "92", "90", "93", "91", "89", "93", "91", "89", "112", "110", "108", "122", "120", "118", "118", "141", "139", "140", "138", "136", "148", "170", "168", "190", "188", "186"})
        Me.Polish_Standard_UIA_FDA_web_depth.Location = New System.Drawing.Point(336, 220)
        Me.Polish_Standard_UIA_FDA_web_depth.Name = "Polish_Standard_UIA_FDA_web_depth"
        Me.Polish_Standard_UIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_UIA_FDA_web_depth.Size = New System.Drawing.Size(24, 20)
        Me.Polish_Standard_UIA_FDA_web_depth.TabIndex = 70
        Me.Polish_Standard_UIA_FDA_web_depth.Visible = False
        '
        'Polish_Standard_UIA_FDA_profile_depth
        '
        Me.Polish_Standard_UIA_FDA_profile_depth.ItemHeight = 16
        Me.Polish_Standard_UIA_FDA_profile_depth.Items.AddRange(New Object() {"30", "30", "40", "40", "40", "45", "45", "45", "50", "50", "50", "50", "60", "60", "60", "60", "65", "65", "65", "70", "75", "75", "75", "75", "75", "80", "80", "80", "80", "80", "90", "90", "100", "100", "100", "100", "100", "100", "100", "100", "100", "120", "120", "120", "130", "130", "130", "130", "150", "150", "150", "150", "150", "160", "180", "180", "200", "200", "200"})
        Me.Polish_Standard_UIA_FDA_profile_depth.Location = New System.Drawing.Point(336, 180)
        Me.Polish_Standard_UIA_FDA_profile_depth.Name = "Polish_Standard_UIA_FDA_profile_depth"
        Me.Polish_Standard_UIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_UIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_UIA_FDA_profile_depth.TabIndex = 69
        Me.Polish_Standard_UIA_FDA_profile_depth.Visible = False
        '
        'Polish_Standard_EIA_FDA_flange_breadth
        '
        Me.Polish_Standard_EIA_FDA_flange_breadth.ItemHeight = 16
        Me.Polish_Standard_EIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "25", "30", "30", "35", "35", "40", "40", "45", "45", "50", "50", "50", "60", "60", "60", "65", "65", "65", "75", "75", "75", "75", "75", "80", "80", "80", "90", "90", "90", "90", "90", "90", "100", "100", "100", "120", "120", "130", "150", "150", "160", "160", "180", "180", "200"})
        Me.Polish_Standard_EIA_FDA_flange_breadth.Location = New System.Drawing.Point(300, 288)
        Me.Polish_Standard_EIA_FDA_flange_breadth.Name = "Polish_Standard_EIA_FDA_flange_breadth"
        Me.Polish_Standard_EIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_EIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_EIA_FDA_flange_breadth.TabIndex = 66
        Me.Polish_Standard_EIA_FDA_flange_breadth.Visible = False
        '
        'Polish_Standard_EIA_FDA_web_thickness
        '
        Me.Polish_Standard_EIA_FDA_web_thickness.ItemHeight = 16
        Me.Polish_Standard_EIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "3", "3", "4", "4", "5", "4", "5", "4", "5", "4", "5", "6", "5", "6", "8", "6", "7", "9", "5", "6", "7", "8", "9", "6", "8", "10", "6", "7", "8", "9", "10", "11", "8", "10", "12", "10", "12", "12", "12", "15", "12", "15", "16", "18", "20"})
        Me.Polish_Standard_EIA_FDA_web_thickness.Location = New System.Drawing.Point(300, 264)
        Me.Polish_Standard_EIA_FDA_web_thickness.Name = "Polish_Standard_EIA_FDA_web_thickness"
        Me.Polish_Standard_EIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_EIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_EIA_FDA_web_thickness.TabIndex = 65
        Me.Polish_Standard_EIA_FDA_web_thickness.Visible = False
        '
        'Polish_Standard_EIA_FDA_web_depth
        '
        Me.Polish_Standard_EIA_FDA_web_depth.ItemHeight = 16
        Me.Polish_Standard_EIA_FDA_web_depth.Items.AddRange(New Object() {"17", "22", "27", "26", "31", "30", "36", "35", "41", "40", "46", "45", "44", "55", "54", "52", "59", "58", "56", "70", "69", "68", "67", "66", "74", "72", "70", "84", "83", "82", "81", "80", "79", "92", "90", "88", "110", "108", "118", "138", "135", "148", "145", "164", "162", "180"})
        Me.Polish_Standard_EIA_FDA_web_depth.Location = New System.Drawing.Point(300, 220)
        Me.Polish_Standard_EIA_FDA_web_depth.Name = "Polish_Standard_EIA_FDA_web_depth"
        Me.Polish_Standard_EIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_EIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_EIA_FDA_web_depth.TabIndex = 64
        Me.Polish_Standard_EIA_FDA_web_depth.Visible = False
        '
        'Polish_Standard_EIA_FDA_profile_depth
        '
        Me.Polish_Standard_EIA_FDA_profile_depth.ItemHeight = 16
        Me.Polish_Standard_EIA_FDA_profile_depth.Items.AddRange(New Object() {"20", "25", "30", "30", "35", "35", "40", "40", "45", "45", "50", "50", "50", "60", "60", "60", "65", "65", "65", "75", "75", "75", "75", "75", "80", "80", "80", "90", "90", "90", "90", "90", "90", "100", "100", "100", "120", "120", "130", "150", "150", "160", "160", "180", "180", "200"})
        Me.Polish_Standard_EIA_FDA_profile_depth.Location = New System.Drawing.Point(300, 180)
        Me.Polish_Standard_EIA_FDA_profile_depth.Name = "Polish_Standard_EIA_FDA_profile_depth"
        Me.Polish_Standard_EIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_EIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.Polish_Standard_EIA_FDA_profile_depth.TabIndex = 63
        Me.Polish_Standard_EIA_FDA_profile_depth.Visible = False
        '
        'Korean_Standard_EIA_FDA_flange_breadth
        '
        Me.Korean_Standard_EIA_FDA_flange_breadth.ItemHeight = 16
        Me.Korean_Standard_EIA_FDA_flange_breadth.Items.AddRange(New Object() {"25", "30", "40", "40", "45", "45", "50", "50", "50", "60", "60", "65", "65", "65", "70", "75", "75", "75", "80", "90", "90", "90", "90", "100", "100", "100", "120", "130", "130", "130", "150", "150", "150", "175", "175", "200", "200", "200", "250", "250"})
        Me.Korean_Standard_EIA_FDA_flange_breadth.Location = New System.Drawing.Point(268, 288)
        Me.Korean_Standard_EIA_FDA_flange_breadth.Name = "Korean_Standard_EIA_FDA_flange_breadth"
        Me.Korean_Standard_EIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Korean_Standard_EIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.Korean_Standard_EIA_FDA_flange_breadth.TabIndex = 61
        Me.Korean_Standard_EIA_FDA_flange_breadth.Visible = False
        '
        'Korean_Standard_EIA_FDA_web_thickness
        '
        Me.Korean_Standard_EIA_FDA_web_thickness.ItemHeight = 16
        Me.Korean_Standard_EIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "3", "3", "5", "4", "5", "4", "5", "6", "4", "5", "5", "6", "8", "6", "6", "9", "12", "6", "6", "7", "10", "13", "7", "10", "13", "8", "9", "12", "15", "12", "15", "19", "12", "15", "15", "20", "25", "25", "35"})
        Me.Korean_Standard_EIA_FDA_web_thickness.Location = New System.Drawing.Point(268, 264)
        Me.Korean_Standard_EIA_FDA_web_thickness.Name = "Korean_Standard_EIA_FDA_web_thickness"
        Me.Korean_Standard_EIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Korean_Standard_EIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.Korean_Standard_EIA_FDA_web_thickness.TabIndex = 60
        Me.Korean_Standard_EIA_FDA_web_thickness.Visible = False
        '
        'Korean_Standard_EIA_FDA_web_depth
        '
        Me.Korean_Standard_EIA_FDA_web_depth.ItemHeight = 16
        Me.Korean_Standard_EIA_FDA_web_depth.Items.AddRange(New Object() {"22", "27", "37", "35", "41", "40", "46", "45", "44", "56", "55", "60", "59", "57", "64", "69", "66", "63", "74", "84", "83", "80", "77", "93", "90", "87", "112", "121", "118", "115", "138", "135", "131", "163", "160", "185", "180", "175", "225", "215"})
        Me.Korean_Standard_EIA_FDA_web_depth.Location = New System.Drawing.Point(268, 220)
        Me.Korean_Standard_EIA_FDA_web_depth.Name = "Korean_Standard_EIA_FDA_web_depth"
        Me.Korean_Standard_EIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Korean_Standard_EIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.Korean_Standard_EIA_FDA_web_depth.TabIndex = 59
        Me.Korean_Standard_EIA_FDA_web_depth.Visible = False
        '
        'Korean_Standard_EIA_FDA_profile_depth
        '
        Me.Korean_Standard_EIA_FDA_profile_depth.ItemHeight = 16
        Me.Korean_Standard_EIA_FDA_profile_depth.Items.AddRange(New Object() {"25", "30", "40", "40", "45", "45", "50", "50", "50", "60", "60", "65", "65", "65", "70", "75", "75", "75", "80", "90", "90", "90", "90", "100", "100", "100", "120", "130", "130", "130", "150", "150", "150", "175", "175", "200", "200", "200", "250", "250"})
        Me.Korean_Standard_EIA_FDA_profile_depth.Location = New System.Drawing.Point(268, 180)
        Me.Korean_Standard_EIA_FDA_profile_depth.Name = "Korean_Standard_EIA_FDA_profile_depth"
        Me.Korean_Standard_EIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Korean_Standard_EIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.Korean_Standard_EIA_FDA_profile_depth.TabIndex = 58
        Me.Korean_Standard_EIA_FDA_profile_depth.Visible = False
        '
        'Japanese_Standard_EIA_FDA_flange_breadth
        '
        Me.Japanese_Standard_EIA_FDA_flange_breadth.ItemHeight = 16
        Me.Japanese_Standard_EIA_FDA_flange_breadth.Items.AddRange(New Object() {"50", "65", "65", "75", "75", "75", "90", "90", "90", "90", "100", "100", "100", "130", "130", "130", "150", "150", "150", "150", "175", "175", "200", "200", "200", "200", "250", "250"})
        Me.Japanese_Standard_EIA_FDA_flange_breadth.Location = New System.Drawing.Point(236, 288)
        Me.Japanese_Standard_EIA_FDA_flange_breadth.Name = "Japanese_Standard_EIA_FDA_flange_breadth"
        Me.Japanese_Standard_EIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japanese_Standard_EIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.Japanese_Standard_EIA_FDA_flange_breadth.TabIndex = 57
        Me.Japanese_Standard_EIA_FDA_flange_breadth.Visible = False
        '
        'Japanese_Standard_EIA_FDA_web_thickness
        '
        Me.Japanese_Standard_EIA_FDA_web_thickness.ItemHeight = 16
        Me.Japanese_Standard_EIA_FDA_web_thickness.Items.AddRange(New Object() {"6", "6", "8", "6", "9", "12", "6", "7", "10", "13", "7", "10", "13", "9", "12", "15", "10", "12", "15", "19", "12", "15", "15", "20", "25", "29", "25", "35"})
        Me.Japanese_Standard_EIA_FDA_web_thickness.Location = New System.Drawing.Point(236, 264)
        Me.Japanese_Standard_EIA_FDA_web_thickness.Name = "Japanese_Standard_EIA_FDA_web_thickness"
        Me.Japanese_Standard_EIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japanese_Standard_EIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.Japanese_Standard_EIA_FDA_web_thickness.TabIndex = 56
        Me.Japanese_Standard_EIA_FDA_web_thickness.Visible = False
        '
        'Japanese_Standard_EIA_FDA_web_depth
        '
        Me.Japanese_Standard_EIA_FDA_web_depth.ItemHeight = 16
        Me.Japanese_Standard_EIA_FDA_web_depth.Items.AddRange(New Object() {"44", "59", "57", "69", "66", "63", "84", "83", "80", "77", "93", "90", "87", "121", "118", "115", "140", "138", "135", "131", "163", "160", "185", "180", "175", "171", "225", "215"})
        Me.Japanese_Standard_EIA_FDA_web_depth.Location = New System.Drawing.Point(232, 220)
        Me.Japanese_Standard_EIA_FDA_web_depth.Name = "Japanese_Standard_EIA_FDA_web_depth"
        Me.Japanese_Standard_EIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japanese_Standard_EIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.Japanese_Standard_EIA_FDA_web_depth.TabIndex = 55
        Me.Japanese_Standard_EIA_FDA_web_depth.Visible = False
        '
        'Japanese_Standard_EIA_FDA_profile_depth
        '
        Me.Japanese_Standard_EIA_FDA_profile_depth.ItemHeight = 16
        Me.Japanese_Standard_EIA_FDA_profile_depth.Items.AddRange(New Object() {"50", "65", "65", "75", "75", "75", "90", "90", "90", "90", "100", "100", "100", "130", "130", "130", "150", "150", "150", "150", "175", "175", "200", "200", "200", "200", "250", "250"})
        Me.Japanese_Standard_EIA_FDA_profile_depth.Location = New System.Drawing.Point(232, 180)
        Me.Japanese_Standard_EIA_FDA_profile_depth.Name = "Japanese_Standard_EIA_FDA_profile_depth"
        Me.Japanese_Standard_EIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japanese_Standard_EIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.Japanese_Standard_EIA_FDA_profile_depth.TabIndex = 54
        Me.Japanese_Standard_EIA_FDA_profile_depth.Visible = False
        '
        'ISO_Standard_UIA_FDA_flange_breadth
        '
        Me.ISO_Standard_UIA_FDA_flange_breadth.ItemHeight = 16
        Me.ISO_Standard_UIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "20", "25", "25", "25", "30", "30", "40", "40", "50", "50", "50", "50", "50", "50", "50", "50", "50", "40", "60", "60", "60", "65", "60", "50", "65", "65", "65", "75", "80", "80", "80", "65", "100", "100", "100", "100"})
        Me.ISO_Standard_UIA_FDA_flange_breadth.Location = New System.Drawing.Point(196, 288)
        Me.ISO_Standard_UIA_FDA_flange_breadth.Name = "ISO_Standard_UIA_FDA_flange_breadth"
        Me.ISO_Standard_UIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_UIA_FDA_flange_breadth.Size = New System.Drawing.Size(32, 20)
        Me.ISO_Standard_UIA_FDA_flange_breadth.TabIndex = 52
        Me.ISO_Standard_UIA_FDA_flange_breadth.Visible = False
        '
        'ISO_Standard_UIA_FDA_web_thickness
        '
        Me.ISO_Standard_UIA_FDA_web_thickness.ItemHeight = 16
        Me.ISO_Standard_UIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "4", "4", "5", "6", "4", "5", "5", "6", "5", "6", "7", "8", "7", "5", "6", "7", "8", "6", "6", "7", "8", "10", "8", "8", "7", "8", "10", "8", "8", "10", "12", "10", "10", "12", "10", "12"})
        Me.ISO_Standard_UIA_FDA_web_thickness.Location = New System.Drawing.Point(196, 264)
        Me.ISO_Standard_UIA_FDA_web_thickness.Name = "ISO_Standard_UIA_FDA_web_thickness"
        Me.ISO_Standard_UIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_UIA_FDA_web_thickness.Size = New System.Drawing.Size(32, 20)
        Me.ISO_Standard_UIA_FDA_web_thickness.TabIndex = 51
        Me.ISO_Standard_UIA_FDA_web_thickness.Visible = False
        '
        'ISO_Standard_UIA_FDA_web_depth
        '
        Me.ISO_Standard_UIA_FDA_web_depth.ItemHeight = 16
        Me.ISO_Standard_UIA_FDA_web_depth.Items.AddRange(New Object() {"27", "26", "36", "35", "34", "41", "40", "55", "54", "60", "59", "58", "57", "63", "70", "69", "68", "67", "74", "74", "73", "72", "70", "82", "92", "93", "92", "90", "92", "112", "110", "108", "120", "140", "138", "190", "188"})
        Me.ISO_Standard_UIA_FDA_web_depth.Location = New System.Drawing.Point(196, 220)
        Me.ISO_Standard_UIA_FDA_web_depth.Name = "ISO_Standard_UIA_FDA_web_depth"
        Me.ISO_Standard_UIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_UIA_FDA_web_depth.Size = New System.Drawing.Size(32, 20)
        Me.ISO_Standard_UIA_FDA_web_depth.TabIndex = 50
        Me.ISO_Standard_UIA_FDA_web_depth.Visible = False
        '
        'ISO_Standard_UIA_FDA_profile_depth
        '
        Me.ISO_Standard_UIA_FDA_profile_depth.ItemHeight = 16
        Me.ISO_Standard_UIA_FDA_profile_depth.Items.AddRange(New Object() {"30", "30", "40", "40", "40", "45", "45", "60", "60", "65", "65", "65", "65", "70", "75", "75", "75", "75", "80", "80", "80", "80", "80", "90", "100", "100", "100", "100", "100", "120", "120", "120", "130", "150", "150", "200", "200"})
        Me.ISO_Standard_UIA_FDA_profile_depth.Location = New System.Drawing.Point(196, 180)
        Me.ISO_Standard_UIA_FDA_profile_depth.Name = "ISO_Standard_UIA_FDA_profile_depth"
        Me.ISO_Standard_UIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_UIA_FDA_profile_depth.Size = New System.Drawing.Size(32, 20)
        Me.ISO_Standard_UIA_FDA_profile_depth.TabIndex = 49
        Me.ISO_Standard_UIA_FDA_profile_depth.Visible = False
        '
        'DIN_Standard_UIA_FDA_names
        '
        Me.DIN_Standard_UIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.DIN_Standard_UIA_FDA_names.ItemHeight = 16
        Me.DIN_Standard_UIA_FDA_names.Items.AddRange(New Object() {"30.0 x 20.0 x 3.0/3.0 IA", "30.0 x 20.0 x 4.0/4.0 IA", "40.0 x 20.0 x 4.0/4.0 IA", "40.0 x 25.0 x 4.0/4.0 IA", "45.0 x 30.0 x 5.0/5.0 IA", "50.0 x 30.0 x 4.0/4.0 IA", "50.0 x 30.0 x 5.0/5.0 IA", "50.0 x 40.0 x 5.0/5.0 IA", "60.0 x 30.0 x 5.0/5.0 IA", "60.0 x 30.0 x 6.0/6.0 IA", "60.0 x 40.0 x 5.0/5.0 IA", "60.0 x 40.0 x 6.0/6.0 IA", "60.0 x 50.0 x 6.0/6.0 IA", "60.0 x 50.0 x 8.0/8.0 IA", "65.0 x 50.0 x 5.0/5.0 IA", "65.0 x 50.0 x 6.0/6.0 IA", "65.0 x 50.0 x 8.0/8.0 IA", "70.0 x 50.0 x 6.0/6.0 IA", "70.0 x 50.0 x 7.0/7.0 IA", "75.0 x 50.0 x 6.0/6.0 IA", "75.0 x 50.0 x 8.0/8.0 IA", "80.0 x 40.0 x 6.0/6.0 IA", "80.0 x 40.0 x 8.0/8.0 IA", "80.0 x 60.0 x 6.0/6.0 IA", "80.0 x 60.0 x 7.0/7.0 IA", "80.0 x 60.0 x 8.0/8.0 IA", "90.0 x 60.0 x 8.0/8.0 IA", "90.0 x 65.0 x 6.0/6.0 IA", "90.0 x 65.0 x 8.0/8.0 IA", "90.0 x 75.0 x 8.0/8.0 IA", "90.0 x 75.0 x 10.0/10.0 IA", "90.0 x 75.0 x 13.0/13.0 IA", "100.0 x 50.0 x 6.0/6.0 IA", "100.0 x 50.0 x 8.0/8.0 IA", "100.0 x 50.0 x 10.0/10.0 IA", "100.0 x 65.0 x 7.0/7.0 IA", "100.0 x 65.0 x 8.0/8.0 IA", "100.0 x 65.0 x 10.0/10.0 IA", "100.0 x 75.0 x 8.0/8.0 IA", "100.0 x 75.0 x 10.0/10.0 IA", "100.0 x 75.0 x 12.0/12.0 IA", "100.0 x 90.0 x 10.0/10.0 IA", "100.0 x 90.0 x 13.0/13.0 IA", "120.0 x 80.0 x 8.0/8.0 IA", "120.0 x 80.0 x 10.0/10.0 IA", "120.0 x 80.0 x 12.0/12.0 IA", "125.0 x 75.0 x 8.0/8.0 IA", "125.0 x 75.0 x 10.0/10.0 IA", "125.0 x 75.0 x 12.0/12.0 IA", "125.0 x 90.0 x 10.0/10.0 IA", "125.0 x 90.0 x 13.0/13.0 IA", "135.0 x 65.0 x 8.0/8.0 IA", "135.0 x 65.0 x 10.0/10.0 IA", "150.0 x 75.0 x 9.0/9.0 IA", "150.0 x 75.0 x 10.0/10.0 IA", "150.0 x 75.0 x 12.0/12.0 IA", "150.0 x 75.0 x 15.0/15.0 IA", "150.0 x 90.0 x 10.0/10.0 IA", "150.0 x 90.0 x 12.0/12.0 IA", "150.0 x 90.0 x 15.0/15.0 IA", "150.0 x 100.0 x 10.0/10.0 IA", "150.0 x 100.0 x 12.0/12.0 IA", "150.0 x 100.0 x 16.0/16.0 IA", "180.0 x 90.0 x 10.0/10.0 IA", "200.0 x 100.0 x 10.0/10.0 IA", "200.0 x 100.0 x 12.0/12.0 IA", "200.0 x 100.0 x 14.0/14.0 IA", "200.0 x 100.0 x 16.0/16.0 IA", "200.0 x 150.0 x 12.0/12.0 IA", "200.0 x 150.0 x 12.0/25.0 IA", "200.0 x 150.0 x 15.0/15.0 IA", "200.0 x 150.0 x 20.0/20.0 IA"})
        Me.DIN_Standard_UIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.DIN_Standard_UIA_FDA_names.Name = "DIN_Standard_UIA_FDA_names"
        Me.DIN_Standard_UIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_UIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.DIN_Standard_UIA_FDA_names.TabIndex = 33
        '
        'DIN_Standard_EIA_FDA_names
        '
        Me.DIN_Standard_EIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.DIN_Standard_EIA_FDA_names.ItemHeight = 16
        Me.DIN_Standard_EIA_FDA_names.Items.AddRange(New Object() {"20.0 x 20.0 x 3.0/3.0 IA", "25.0 x 25.0 x 3.0/3.0 IA", "25.0 x 25.0 x 4.0/4.0 IA", "30.0 x 30.0 x 3.0/3.0 IA", "30.0 x 30.0 x 4.0/4.0 IA", "30.0 x 30.0 x 5.0/5.0 IA", "35.0 x 35.0 x 4.0/4.0 IA", "35.0 x 35.0 x 5.0/5.0 IA", "40.0 x 40.0 x 4.0/4.0 IA", "40.0 x 40.0 x 5.0/5.0 IA", "45.0 x 45.0 x 4.0/4.0 IA", "45.0 x 45.0 x 5.0/5.0 IA", "50.0 x 50.0 x 5.0/5.0 IA", "50.0 x 50.0 x 6.0/6.0 IA", "50.0 x 50.0 x 7.0/7.0 IA", "55.0 x 55.0 x 6.0/6.0 IA", "60.0 x 60.0 x 5.0/5.0 IA", "60.0 x 60.0 x 6.0/6.0 IA", "60.0 x 60.0 x 8.0/8.0 IA", "65.0 x 65.0 x 7.0/7.0 IA", "70.0 x 70.0 x 6.0/6.0 IA", "70.0 x 70.0 x 7.0/7.0 IA", "70.0 x 70.0 x 9.0/9.0 IA", "75.0 x 75.0 x 7.0/7.0 IA", "75.0 x 75.0 x 8.0/8.0 IA", "80.0 x 80.0 x 6.0/6.0 IA", "80.0 x 80.0 x 8.0/8.0 IA", "80.0 x 80.0 x 10.0/10.0 IA", "90.0 x 90.0 x 7.0/7.0 IA", "90.0 x 90.0 x 9.0/9.0 IA", "100.0 x 100.0 x 8.0/8.0 IA", "100.0 x 100.0 x 10.0/10.0 IA", "100.0 x 100.0 x 12.0/12.0 IA", "110.0 x 110.0 x 10.0/10.0 IA", "120.0 x 120.0 x 10.0/10.0 IA", "120.0 x 120.0 x 11.0/11.0 IA", "120.0 x 120.0 x 12.0/12.0 IA", "130.0 x 130.0 x 12.0/12.0 IA", "140.0 x 140.0 x 13.0/13.0 IA", "150.0 x 150.0 x 12.0/12.0 IA", "150.0 x 150.0 x 14.0/14.0 IA", "150.0 x 150.0 x 15.0/15.0 IA", "160.0 x 160.0 x 15.0/15.0 IA", "160.0 x 160.0 x 17.0/17.0 IA", "170.0 x 170.0 x 16.0/16.0 IA", "170.0 x 170.0 x 18.0/18.0 IA", "200.0 x 200.0 x 16.0/16.0 IA", "200.0 x 200.0 x 18.0/18.0 IA", "200.0 x 200.0 x 20.0/20.0 IA", "200.0 x 200.0 x 24.0/24.0 IA"})
        Me.DIN_Standard_EIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.DIN_Standard_EIA_FDA_names.Name = "DIN_Standard_EIA_FDA_names"
        Me.DIN_Standard_EIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_EIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.DIN_Standard_EIA_FDA_names.TabIndex = 28
        '
        'Label_title01
        '
        Me.Label_title01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title01.Location = New System.Drawing.Point(12, 20)
        Me.Label_title01.Name = "Label_title01"
        Me.Label_title01.Size = New System.Drawing.Size(188, 20)
        Me.Label_title01.TabIndex = 24
        Me.Label_title01.Text = "שם החיזוק לפי התקן"
        '
        'British_Standard_UEA_FDA_names
        '
        Me.British_Standard_UEA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.British_Standard_UEA_FDA_names.ItemHeight = 16
        Me.British_Standard_UEA_FDA_names.Items.AddRange(New Object() {"63.0 x 51.0 x 4.6/4.6 IA", "63.0 x 51.0 x 6.3/6.3 IA", "63.0 x 51.0 x 7.8/7.8 IA", "63.0 x 51.0 x 9.3/9.3 IA", "63.0 x 51.0 x 11.0/11.0 IA", "76.0 x 51.0 x 4.8/4.8 IA", "76.0 x 51.0 x 6.2/6.2 IA", "76.0 x 51.0 x 7.9/7.9 IA", "76.0 x 51.0 x 9.5/9.5 IA", "76.0 x 51.0 x 11.1/11.1 IA", "76.0 x 51.0 x 12.5/12.5 IA", "76.0 x 63.0 x 6.3/6.3 IA", "76.0 x 63.0 x 7.9/7.9 IA", "76.0 x 63.0 x 9.5/9.5 IA", "76.0 x 63.0 x 11.1/11.1 IA", "76.0 x 63.0 x 12.7/12.7 IA", "89.0 x 63.0 x 6.2/6.2 IA", "89.0 x 63.0 x 7.9/7.9 IA", "89.0 x 63.0 x 9.4/9.4 IA", "89.0 x 63.0 x 11.0/11.0 IA", "89.0 x 63.0 x 12.6/12.6 IA", "89.0 x 76.0 x 6.2/6.2 IA", "89.0 x 76.0 x 7.9/7.9 IA", "89.0 x 76.0 x 9.5/9.5 IA", "89.0 x 76.0 x 11.1/11.1 IA", "89.0 x 76.0 x 12.9/12.9 IA", "89.0 x 76.0 x 14.2/14.2 IA", "89.0 x 76.0 x 15.9/15.9 IA", "102.0 x 63.0 x 6.3/6.3 IA", "102.0 x 63.0 x 7.8/7.8 IA", "102.0 x 63.0 x 9.5/9.5 IA", "102.0 x 63.0 x 11.1/11.1 IA", "102.0 x 63.0 x 12.7/12.7 IA", "102.0 x 76.0 x 6.3/6.3 IA", "102.0 x 76.0 x 7.9/7.9 IA", "102.0 x 76.0 x 9.4/9.4 IA", "102.0 x 76.0 x 11.0/11.0 IA", "102.0 x 76.0 x 12.6/12.6 IA", "102.0 x 76.0 x 14.2/14.2 IA", "102.0 x 76.0 x 15.8/15.8 IA", "102.0 x 89.0 x 7.9/7.9 IA", "102.0 x 89.0 x 9.6/9.6 IA", "102.0 x 89.0 x 11.1/11.1 IA", "102.0 x 89.0 x 12.7/12.7 IA", "102.0 x 89.0 x 14.2/14.2 IA", "102.0 x 89.0 x 16.8/16.8 IA", "127.0 x 76.0 x 6.3/6.3 IA", "127.0 x 76.0 x 7.8/7.8 IA", "127.0 x 76.0 x 9.5/9.5 IA", "127.0 x 76.0 x 11.0/11.0 IA", "127.0 x 76.0 x 12.6/12.6 IA", "127.0 x 76.0 x 14.2/14.2 IA", "127.0 x 76.0 x 15.9/15.9 IA", "127.0 x 89.0 x 7.9/7.9 IA", "127.0 x 89.0 x 9.4/9.4 IA", "127.0 x 89.0 x 11.1/11.1 IA", "127.0 x 89.0 x 12.7/12.7 IA", "127.0 x 89.0 x 14.3/14.3 IA", "127.0 x 89.0 x 15.8/15.8 IA", "127.0 x 102.0 x 7.9/7.9 IA", "127.0 x 102.0 x 9.5/9.5 IA", "127.0 x 102.0 x 11.0/11.0 IA", "127.0 x 102.0 x 12.6/12.6 IA", "127.0 x 102.0 x 14.2/14.2 IA", "127.0 x 102.0 x 15.8/15.8 IA", "152.0 x 76.0 x 7.9/7.9 IA", "152.0 x 76.0 x 9.5/9.5 IA", "152.0 x 76.0 x 11.0/11.0 IA", "152.0 x 76.0 x 12.6/12.6 IA", "152.0 x 76.0 x 14.2/14.2 IA", "152.0 x 76.0 x 15.8/15.8 IA", "152.0 x 89.0 x 7.8/7.8 IA", "152.0 x 89.0 x 9.4/9.4 IA", "152.0 x 89.0 x 11.1/11.1 IA", "152.0 x 89.0 x 12.8/12.8 IA", "152.0 x 89.0 x 14.2/14.2 IA", "152.0 x 89.0 x 15.8/15.8 IA", "152.0 x 102.0 x 9.5/9.5 IA", "152.0 x 102.0 x 11.0/11.0 IA", "152.0 x 102.0 x 12.8/12.8 IA", "152.0 x 102.0 x 14.2/14.2 IA", "152.0 x 102.0 x 15.8/15.8 IA", "152.0 x 102.0 x 17.5/17.5 IA", "152.0 x 102.0 x 19.0/19.0 IA", "178.0 x 89.0 x 9.5/9.5 IA", "178.0 x 89.0 x 11.1/11.1 IA", "178.0 x 89.0 x 12.6/12.6 IA", "178.0 x 89.0 x 14.2/14.2 IA", "178.0 x 89.0 x 15.8/15.8 IA", "178.0 x 102.0 x 9.4/9.4 IA", "178.0 x 102.0 x 11.0/11.0 IA", "178.0 x 102.0 x 12.6/12.6 IA", "178.0 x 102.0 x 14.2/14.2 IA", "178.0 x 102.0 x 15.8/15.8 IA", "178.0 x 102.0 x 17.4/17.4 IA", "178.0 x 102.0 x 19.0/19.0 IA", "203.0 x 89.0 x 9.5/9.5 IA", "203.0 x 89.0 x 11.0/11.0 IA", "203.0 x 89.0 x 12.6/12.6 IA", "203.0 x 89.0 x 14.2/14.2 IA", "203.0 x 89.0 x 15.8/15.8 IA", "203.0 x 102.0 x 11.0/11.0 IA", "203.0 x 102.0 x 12.6/12.6 IA", "203.0 x 102.0 x 14.3/14.3 IA", "203.0 x 102.0 x 15.8/15.8 IA", "203.0 x 102.0 x 17.9/17.9 IA", "203.0 x 102.0 x 19.0/19.0 IA", "203.0 x 152.0 x 12.6/12.6 IA", "203.0 x 152.0 x 14.2/14.2 IA", "203.0 x 152.0 x 15.8/15.8 IA", "203.0 x 152.0 x 17.4/17.4 IA", "203.0 x 152.0 x 19.0/19.0 IA", "203.0 x 152.0 x 20.5/20.5 IA", "203.0 x 152.0 x 22.1/22.1 IA", "229.0 x 102.0 x 11.0/11.0 IA", "229.0 x 102.0 x 12.6/12.6 IA", "229.0 x 102.0 x 14.2/14.2 IA", "229.0 x 102.0 x 15.8/15.8 IA", "229.0 x 102.0 x 17.4/17.4 IA", "229.0 x 102.0 x 18.9/18.9 IA", "229.0 x 102.0 x 20.6/20.6 IA", "229.0 x 102.0 x 22.2/22.2 IA", "254.0 x 102.0 x 11.0/11.0 IA", "254.0 x 102.0 x 12.6/12.6 IA", "254.0 x 102.0 x 14.3/14.3 IA", "254.0 x 102.0 x 15.8/15.8 IA", "254.0 x 102.0 x 17.4/17.4 IA", "254.0 x 102.0 x 19.0/19.0 IA"})
        Me.British_Standard_UEA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.British_Standard_UEA_FDA_names.Name = "British_Standard_UEA_FDA_names"
        Me.British_Standard_UEA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.British_Standard_UEA_FDA_names.TabIndex = 16
        '
        'British_Standard_UEA_FDA_web_thickness
        '
        Me.British_Standard_UEA_FDA_web_thickness.ItemHeight = 16
        Me.British_Standard_UEA_FDA_web_thickness.Items.AddRange(New Object() {"4.60", "6.25", "7.77", "9.32", "10.95", "4.75", "6.22", "7.90", "9.45", "11.05", "12.52", "6.25", "7.90", "9.45", "11.06", "12.67", "6.22", "7.85", "9.40", "10.97", "12.60", "6.22", "7.85", "9.47", "11.06", "12.87", "14.17", "15.85", "6.30", "7.82", "9.47", "11.06", "12.67", "6.27", "7.90", "9.42", "11.00", "12.60", "14.22", "15.77", "7.85", "9.60", "11.06", "12.65", "14.17", "16.82", "6.32", "7.82", "9.45", "11.02", "12.60", "14.22", "15.85", "7.87", "9.43", "11.07", "12.65", "14.25", "15.77", "7.85", "9.47", "11.02", "12.60", "14.20", "15.82", "7.85", "9.47", "11.02", "12.60", "14.20", "15.82", "7.82", "9.42", "11.07", "12.82", "14.22", "15.75", "9.47", "11.02", "12.80", "14.17", "15.80", "17.48", "19.00", "9.45", "11.07", "12.62", "14.20", "15.82", "9.42", "11.02", "12.60", "14.17", "15.77", "17.37", "18.95", "9.45", "11.00", "12.62", "14.20", "15.77", "11.02", "12.60", "14.28", "15.82", "17.85", "18.97", "12.57", "14.20", "15.77", "17.35", "18.96", "20.52", "22.10", "11.02", "12.57", "14.20", "15.80", "17.37", "18.92", "20.57", "22.15", "10.97", "12.57", "14.25", "15.77", "17.35", "18.95"})
        Me.British_Standard_UEA_FDA_web_thickness.Location = New System.Drawing.Point(384, 264)
        Me.British_Standard_UEA_FDA_web_thickness.Name = "British_Standard_UEA_FDA_web_thickness"
        Me.British_Standard_UEA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.British_Standard_UEA_FDA_web_thickness.TabIndex = 19
        Me.British_Standard_UEA_FDA_web_thickness.Visible = False
        '
        'British_Standard_UEA_FDA_web_depth
        '
        Me.British_Standard_UEA_FDA_web_depth.ItemHeight = 16
        Me.British_Standard_UEA_FDA_web_depth.Items.AddRange(New Object() {"58.40", "56.75", "55.23", "53.68", "52.05", "71.25", "69.78", "68.10", "66.55", "64.95", "63.48", "69.75", "68.10", "66.55", "64.94", "63.33", "82.78", "81.15", "79.60", "78.03", "76.40", "82.78", "81.15", "79.53", "77.94", "76.13", "74.83", "73.15", "95.70", "94.18", "92.53", "90.94", "89.33", "95.73", "94.10", "92.58", "91.00", "89.40", "87.78", "86.23", "94.15", "92.40", "90.94", "89.35", "87.83", "85.18", "120.68", "119.18", "117.55", "115.98", "114.40", "112.78", "111.15", "119.13", "117.57", "115.93", "114.35", "112.75", "111.23", "119.15", "117.53", "115.98", "114.40", "112.80", "111.18", "144.15", "142.53", "140.98", "139.40", "137.80", "136.18", "144.18", "142.58", "140.93", "139.18", "137.78", "136.25", "142.53", "140.98", "139.20", "137.83", "136.20", "134.52", "133.00", "168.55", "166.93", "165.38", "163.80", "162.18", "168.58", "166.98", "165.40", "163.83", "162.23", "160.63", "159.05", "193.55", "192.00", "190.38", "188.80", "187.23", "191.98", "190.40", "188.72", "187.18", "185.15", "184.03", "190.43", "188.80", "187.23", "185.65", "184.04", "182.48", "180.90", "217.98", "216.43", "214.80", "213.20", "211.63", "210.08", "208.43", "206.85", "243.03", "241.43", "239.75", "238.23", "236.65", "235.05"})
        Me.British_Standard_UEA_FDA_web_depth.Location = New System.Drawing.Point(384, 220)
        Me.British_Standard_UEA_FDA_web_depth.Name = "British_Standard_UEA_FDA_web_depth"
        Me.British_Standard_UEA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.British_Standard_UEA_FDA_web_depth.TabIndex = 18
        Me.British_Standard_UEA_FDA_web_depth.Visible = False
        '
        'British_Standard_UEA_FDA_profile_depth
        '
        Me.British_Standard_UEA_FDA_profile_depth.ItemHeight = 16
        Me.British_Standard_UEA_FDA_profile_depth.Items.AddRange(New Object() {"63", "63", "63", "63", "63", "76", "76", "76", "76", "76", "76", "76", "76", "76", "76", "76", "89", "89", "89", "89", "89", "89", "89", "89", "89", "89", "89", "89", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "127", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "152", "178", "178", "178", "178", "178", "178", "178", "178", "178", "178", "178", "178", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "203", "229", "229", "229", "229", "229", "229", "229", "229", "254", "254", "254", "254", "254", "254"})
        Me.British_Standard_UEA_FDA_profile_depth.Location = New System.Drawing.Point(384, 180)
        Me.British_Standard_UEA_FDA_profile_depth.Name = "British_Standard_UEA_FDA_profile_depth"
        Me.British_Standard_UEA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.British_Standard_UEA_FDA_profile_depth.TabIndex = 17
        Me.British_Standard_UEA_FDA_profile_depth.Visible = False
        '
        'ISO_Standard_EIA_FDA_flange_breadth
        '
        Me.ISO_Standard_EIA_FDA_flange_breadth.ItemHeight = 16
        Me.ISO_Standard_EIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "25", "25", "30", "30", "35", "35", "40", "40", "40", "45", "45", "50", "50", "50", "60", "60", "60", "65", "65", "70", "70", "75", "75", "80", "80", "80", "90", "90", "90", "90", "100", "100", "100", "120", "120", "120", "125", "125", "125", "150", "150", "150", "180", "180", "200", "200", "200", "250", "250"})
        Me.ISO_Standard_EIA_FDA_flange_breadth.Location = New System.Drawing.Point(524, 296)
        Me.ISO_Standard_EIA_FDA_flange_breadth.Name = "ISO_Standard_EIA_FDA_flange_breadth"
        Me.ISO_Standard_EIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_EIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.ISO_Standard_EIA_FDA_flange_breadth.TabIndex = 47
        Me.ISO_Standard_EIA_FDA_flange_breadth.Visible = False
        '
        'ISO_Standard_EIA_FDA_web_thickness
        '
        Me.ISO_Standard_EIA_FDA_web_thickness.ItemHeight = 16
        Me.ISO_Standard_EIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "3", "4", "3", "4", "4", "5", "3", "4", "5", "4", "5", "4", "5", "6", "5", "6", "8", "6", "8", "6", "7", "6", "8", "6", "8", "10", "7", "8", "9", "10", "8", "10", "12", "8", "10", "12", "8", "10", "12", "10", "12", "15", "15", "18", "16", "20", "24", "28", "35"})
        Me.ISO_Standard_EIA_FDA_web_thickness.Location = New System.Drawing.Point(528, 268)
        Me.ISO_Standard_EIA_FDA_web_thickness.Name = "ISO_Standard_EIA_FDA_web_thickness"
        Me.ISO_Standard_EIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_EIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.ISO_Standard_EIA_FDA_web_thickness.TabIndex = 46
        Me.ISO_Standard_EIA_FDA_web_thickness.Visible = False
        '
        'ISO_Standard_EIA_FDA_web_depth
        '
        Me.ISO_Standard_EIA_FDA_web_depth.ItemHeight = 16
        Me.ISO_Standard_EIA_FDA_web_depth.Items.AddRange(New Object() {"17", "22", "21", "27", "26", "31", "30", "37", "36", "35", "41", "40", "46", "45", "44", "55", "54", "52", "59", "57", "64", "63", "69", "67", "74", "72", "70", "83", "82", "81", "80", "92", "90", "88", "112", "110", "108", "117", "115", "113", "140", "138", "135", "165", "162", "184", "180", "176", "222", "215"})
        Me.ISO_Standard_EIA_FDA_web_depth.Location = New System.Drawing.Point(528, 224)
        Me.ISO_Standard_EIA_FDA_web_depth.Name = "ISO_Standard_EIA_FDA_web_depth"
        Me.ISO_Standard_EIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_EIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.ISO_Standard_EIA_FDA_web_depth.TabIndex = 45
        Me.ISO_Standard_EIA_FDA_web_depth.Visible = False
        '
        'ISO_Standard_EIA_FDA_profile_depth
        '
        Me.ISO_Standard_EIA_FDA_profile_depth.ItemHeight = 16
        Me.ISO_Standard_EIA_FDA_profile_depth.Items.AddRange(New Object() {"20", "25", "25", "30", "30", "35", "35", "40", "40", "40", "45", "45", "50", "50", "50", "60", "60", "60", "65", "65", "70", "70", "75", "75", "80", "80", "80", "90", "90", "90", "90", "100", "100", "100", "120", "120", "120", "125", "125", "125", "150", "150", "150", "180", "180", "200", "200", "200", "250", "250"})
        Me.ISO_Standard_EIA_FDA_profile_depth.Location = New System.Drawing.Point(528, 184)
        Me.ISO_Standard_EIA_FDA_profile_depth.Name = "ISO_Standard_EIA_FDA_profile_depth"
        Me.ISO_Standard_EIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_EIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.ISO_Standard_EIA_FDA_profile_depth.TabIndex = 44
        Me.ISO_Standard_EIA_FDA_profile_depth.Visible = False
        '
        'European_Standard_UIA_FDA_flange_breadth
        '
        Me.European_Standard_UIA_FDA_flange_breadth.ItemHeight = 16
        Me.European_Standard_UIA_FDA_flange_breadth.Items.AddRange(New Object() {"16", "20", "20", "20", "20", "25", "25", "28", "28", "30", "30", "32", "32", "36", "36", "36", "40", "40", "40", "40", "40", "40", "40", "45", "45", "50", "50", "50", "50", "50", "50", "55", "55", "55", "56", "56", "56", "60", "60", "60", "63", "63", "63", "63", "75", "75", "75", "70", "70", "70", "80", "80", "80", "80", "80", "80", "80", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "100", "100", "100", "110", "110", "120", "120", "120", "120", "120", "120", "125", "125", "125", "150", "150", "150", "160", "160", "160", "160"})
        Me.European_Standard_UIA_FDA_flange_breadth.Location = New System.Drawing.Point(488, 292)
        Me.European_Standard_UIA_FDA_flange_breadth.Name = "European_Standard_UIA_FDA_flange_breadth"
        Me.European_Standard_UIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.European_Standard_UIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.European_Standard_UIA_FDA_flange_breadth.TabIndex = 42
        Me.European_Standard_UIA_FDA_flange_breadth.Visible = False
        '
        'European_Standard_UIA_FDA_web_thickness
        '
        Me.European_Standard_UIA_FDA_web_thickness.ItemHeight = 16
        Me.European_Standard_UIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "3", "4", "3", "4", "3", "4", "3", "4", "4", "6", "3", "4", "3.5", "4", "5", "5", "6", "8", "4", "5", "6", "8", "4.5", "5", "5", "6", "8", "10", "5", "6", "6", "8", "10", "5.5", "6", "8", "6", "8", "10", "6", "7", "8", "10", "8", "10", "12", "6.5", "7", "8", "8", "10", "12", "7", "8", "10", "12", "8", "10", "12", "14", "8", "10", "10", "12", "14", "16", "9", "10", "12", "14", "10", "12", "12", "14", "16", "12", "14", "16", "11", "12", "14", "12", "16", "18", "12", "16", "18", "20"})
        Me.European_Standard_UIA_FDA_web_thickness.Location = New System.Drawing.Point(488, 264)
        Me.European_Standard_UIA_FDA_web_thickness.Name = "European_Standard_UIA_FDA_web_thickness"
        Me.European_Standard_UIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.European_Standard_UIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.European_Standard_UIA_FDA_web_thickness.TabIndex = 41
        Me.European_Standard_UIA_FDA_web_thickness.Visible = False
        '
        'European_Standard_UIA_FDA_web_depth
        '
        Me.European_Standard_UIA_FDA_web_depth.ItemHeight = 16
        Me.European_Standard_UIA_FDA_web_depth.Items.AddRange(New Object() {"22", "27", "26", "29", "28", "37", "36", "42", "41", "41", "39", "47", "46", "52.5", "52", "51", "55", "54", "52", "59", "58", "57", "55", "65.5", "65", "70", "69", "67", "65", "75", "74", "74", "72", "70", "84.5", "84", "82", "84", "82", "80", "94", "93", "92", "90", "92", "90", "88", "103.5", "103", "102", "112", "110", "108", "118", "117", "115", "113", "122", "120", "118", "116", "132", "130", "140", "138", "136", "134", "151", "150", "148", "146", "170", "168", "168", "166", "164", "188", "186", "184", "189", "188", "186", "188", "184", "182", "238", "234", "232", "230"})
        Me.European_Standard_UIA_FDA_web_depth.Location = New System.Drawing.Point(488, 220)
        Me.European_Standard_UIA_FDA_web_depth.Name = "European_Standard_UIA_FDA_web_depth"
        Me.European_Standard_UIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.European_Standard_UIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.European_Standard_UIA_FDA_web_depth.TabIndex = 40
        Me.European_Standard_UIA_FDA_web_depth.Visible = False
        '
        'European_Standard_UIA_FDA_profile_depth
        '
        Me.European_Standard_UIA_FDA_profile_depth.ItemHeight = 16
        Me.European_Standard_UIA_FDA_profile_depth.Items.AddRange(New Object() {"25", "30", "30", "32", "32", "40", "40", "45", "45", "45", "45", "50", "50", "56", "56", "56", "60", "60", "60", "63", "63", "63", "63", "70", "70", "75", "75", "75", "75", "80", "80", "80", "80", "80", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "100", "100", "110", "110", "110", "120", "120", "120", "125", "125", "125", "125", "130", "130", "130", "130", "140", "140", "150", "150", "150", "150", "160", "160", "160", "160", "180", "180", "180", "180", "180", "200", "200", "200", "200", "200", "200", "200", "200", "200", "250", "250", "250", "250"})
        Me.European_Standard_UIA_FDA_profile_depth.Location = New System.Drawing.Point(488, 180)
        Me.European_Standard_UIA_FDA_profile_depth.Name = "European_Standard_UIA_FDA_profile_depth"
        Me.European_Standard_UIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.European_Standard_UIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.European_Standard_UIA_FDA_profile_depth.TabIndex = 39
        Me.European_Standard_UIA_FDA_profile_depth.Visible = False
        '
        'DIN_Standard_UIA_FDA_flange_breadth
        '
        Me.DIN_Standard_UIA_FDA_flange_breadth.ItemHeight = 16
        Me.DIN_Standard_UIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "20", "20", "25", "30", "30", "30", "40", "30", "30", "40", "40", "50", "50", "50", "50", "50", "50", "50", "50", "50", "40", "40", "60", "60", "60", "60", "65", "65", "75", "75", "75", "50", "50", "50", "65", "65", "65", "75", "75", "75", "90", "90", "80", "80", "80", "75", "75", "75", "90", "90", "65", "65", "75", "75", "75", "75", "90", "90", "90", "100", "100", "100", "90", "100", "100", "100", "100", "150", "150", "150", "150"})
        Me.DIN_Standard_UIA_FDA_flange_breadth.Location = New System.Drawing.Point(448, 292)
        Me.DIN_Standard_UIA_FDA_flange_breadth.Name = "DIN_Standard_UIA_FDA_flange_breadth"
        Me.DIN_Standard_UIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_UIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_UIA_FDA_flange_breadth.TabIndex = 37
        Me.DIN_Standard_UIA_FDA_flange_breadth.Visible = False
        '
        'DIN_Standard_UIA_FDA_web_thickness
        '
        Me.DIN_Standard_UIA_FDA_web_thickness.ItemHeight = 16
        Me.DIN_Standard_UIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "4", "4", "4", "5", "4", "5", "5", "5", "6", "5", "6", "6", "8", "5", "6", "8", "6", "7", "6", "8", "6", "8", "6", "7", "8", "8", "6", "8", "8", "10", "13", "6", "8", "10", "7", "8", "10", "8", "10", "12", "10", "13", "8", "10", "12", "8", "10", "12", "10", "13", "8", "10", "9", "10", "12", "15", "10", "12", "15", "10", "12", "16", "10", "10", "12", "14", "16", "12", "12", "15", "20"})
        Me.DIN_Standard_UIA_FDA_web_thickness.Location = New System.Drawing.Point(452, 264)
        Me.DIN_Standard_UIA_FDA_web_thickness.Name = "DIN_Standard_UIA_FDA_web_thickness"
        Me.DIN_Standard_UIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_UIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_UIA_FDA_web_thickness.TabIndex = 36
        Me.DIN_Standard_UIA_FDA_web_thickness.Visible = False
        '
        'DIN_Standard_UIA_FDA_web_depth
        '
        Me.DIN_Standard_UIA_FDA_web_depth.ItemHeight = 16
        Me.DIN_Standard_UIA_FDA_web_depth.Items.AddRange(New Object() {"27", "26", "36", "36", "40", "46", "45", "45", "55", "54", "55", "54", "54", "52", "60", "59", "57", "64", "63", "69", "67", "74", "72", "74", "73", "72", "82", "84", "82", "82", "80", "77", "94", "92", "90", "93", "92", "90", "92", "90", "88", "90", "87", "112", "110", "108", "117", "115", "113", "115", "112", "127", "125", "141", "140", "138", "135", "140", "138", "135", "140", "138", "134", "170", "190", "188", "186", "184", "188", "175", "185", "180"})
        Me.DIN_Standard_UIA_FDA_web_depth.Location = New System.Drawing.Point(452, 220)
        Me.DIN_Standard_UIA_FDA_web_depth.Name = "DIN_Standard_UIA_FDA_web_depth"
        Me.DIN_Standard_UIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_UIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_UIA_FDA_web_depth.TabIndex = 35
        Me.DIN_Standard_UIA_FDA_web_depth.Visible = False
        '
        'DIN_Standard_UIA_FDA_profile_depth
        '
        Me.DIN_Standard_UIA_FDA_profile_depth.ItemHeight = 16
        Me.DIN_Standard_UIA_FDA_profile_depth.Items.AddRange(New Object() {"30", "30", "40", "40", "45", "50", "50", "50", "60", "60", "60", "60", "60", "60", "65", "65", "65", "70", "70", "75", "75", "80", "80", "80", "80", "80", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "100", "100", "100", "100", "100", "100", "120", "120", "120", "125", "125", "125", "125", "125", "135", "135", "150", "150", "150", "150", "150", "150", "150", "150", "150", "150", "180", "200", "200", "200", "200", "200", "200", "200", "200"})
        Me.DIN_Standard_UIA_FDA_profile_depth.Location = New System.Drawing.Point(452, 180)
        Me.DIN_Standard_UIA_FDA_profile_depth.Name = "DIN_Standard_UIA_FDA_profile_depth"
        Me.DIN_Standard_UIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_UIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_UIA_FDA_profile_depth.TabIndex = 34
        Me.DIN_Standard_UIA_FDA_profile_depth.Visible = False
        '
        'DIN_Standard_EIA_FDA_flange_breadth
        '
        Me.DIN_Standard_EIA_FDA_flange_breadth.ItemHeight = 16
        Me.DIN_Standard_EIA_FDA_flange_breadth.Items.AddRange(New Object() {"20", "25", "25", "30", "30", "30", "35", "35", "40", "40", "45", "45", "50", "50", "50", "55", "60", "60", "60", "65", "70", "70", "70", "75", "75", "80", "80", "80", "90", "90", "100", "100", "100", "110", "120", "120", "120", "130", "140", "150", "150", "150", "160", "160", "170", "170", "200", "200", "200", "200"})
        Me.DIN_Standard_EIA_FDA_flange_breadth.Location = New System.Drawing.Point(416, 288)
        Me.DIN_Standard_EIA_FDA_flange_breadth.Name = "DIN_Standard_EIA_FDA_flange_breadth"
        Me.DIN_Standard_EIA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_EIA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_EIA_FDA_flange_breadth.TabIndex = 32
        Me.DIN_Standard_EIA_FDA_flange_breadth.Visible = False
        '
        'DIN_Standard_EIA_FDA_web_thickness
        '
        Me.DIN_Standard_EIA_FDA_web_thickness.ItemHeight = 16
        Me.DIN_Standard_EIA_FDA_web_thickness.Items.AddRange(New Object() {"3", "3", "4", "3", "4", "5", "4", "5", "4", "5", "4", "5", "5", "6", "7", "6", "5", "6", "8", "7", "6", "7", "9", "7", "8", "6", "8", "10", "7", "9", "8", "10", "12", "10", "10", "11", "12", "12", "13", "12", "14", "15", "15", "17", "16", "18", "16", "18", "20", "24"})
        Me.DIN_Standard_EIA_FDA_web_thickness.Location = New System.Drawing.Point(416, 264)
        Me.DIN_Standard_EIA_FDA_web_thickness.Name = "DIN_Standard_EIA_FDA_web_thickness"
        Me.DIN_Standard_EIA_FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_EIA_FDA_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_EIA_FDA_web_thickness.TabIndex = 31
        Me.DIN_Standard_EIA_FDA_web_thickness.Visible = False
        '
        'DIN_Standard_EIA_FDA_web_depth
        '
        Me.DIN_Standard_EIA_FDA_web_depth.ItemHeight = 16
        Me.DIN_Standard_EIA_FDA_web_depth.Items.AddRange(New Object() {"17", "22", "21", "27", "26", "25", "31", "30", "36", "35", "41", "40", "45", "44", "43", "49", "55", "54", "52", "58", "64", "63", "61", "68", "67", "74", "72", "70", "83", "81", "92", "90", "88", "100", "110", "109", "108", "118", "127", "138", "136", "135", "145", "143", "154", "152", "184", "182", "180", "176"})
        Me.DIN_Standard_EIA_FDA_web_depth.Location = New System.Drawing.Point(416, 220)
        Me.DIN_Standard_EIA_FDA_web_depth.Name = "DIN_Standard_EIA_FDA_web_depth"
        Me.DIN_Standard_EIA_FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_EIA_FDA_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_EIA_FDA_web_depth.TabIndex = 30
        Me.DIN_Standard_EIA_FDA_web_depth.Visible = False
        '
        'DIN_Standard_EIA_FDA_profile_depth
        '
        Me.DIN_Standard_EIA_FDA_profile_depth.ItemHeight = 16
        Me.DIN_Standard_EIA_FDA_profile_depth.Items.AddRange(New Object() {"20", "25", "25", "30", "30", "30", "35", "35", "40", "40", "45", "45", "50", "50", "50", "55", "60", "60", "60", "65", "70", "70", "70", "75", "75", "80", "80", "80", "90", "90", "100", "100", "100", "110", "120", "120", "120", "130", "140", "150", "150", "150", "160", "160", "170", "170", "200", "200", "200", "200"})
        Me.DIN_Standard_EIA_FDA_profile_depth.Location = New System.Drawing.Point(416, 180)
        Me.DIN_Standard_EIA_FDA_profile_depth.Name = "DIN_Standard_EIA_FDA_profile_depth"
        Me.DIN_Standard_EIA_FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_Standard_EIA_FDA_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.DIN_Standard_EIA_FDA_profile_depth.TabIndex = 29
        Me.DIN_Standard_EIA_FDA_profile_depth.Visible = False
        '
        'British_Standard_UEA_FDA_flange_breadth
        '
        Me.British_Standard_UEA_FDA_flange_breadth.ItemHeight = 16
        Me.British_Standard_UEA_FDA_flange_breadth.Items.AddRange(New Object() {"51", "51", "51", "51", "51", "51", "51", "51", "51", "51", "51", "63", "63", "63", "63", "63", "63", "63", "63", "63", "63", "76", "76", "76", "76", "76", "76", "76", "63", "63", "63", "63", "63", "76", "76", "76", "76", "76", "76", "76", "89", "89", "89", "89", "89", "89", "76", "76", "76", "76", "76", "76", "76", "89", "89", "89", "89", "89", "89", "102", "102", "102", "102", "102", "102", "76", "76", "76", "76", "76", "76", "89", "89", "89", "89", "89", "89", "102", "102", "102", "102", "102", "102", "102", "89", "89", "89", "89", "89", "102", "102", "102", "102", "102", "102", "102", "89", "89", "89", "89", "89", "102", "102", "102", "102", "102", "102", "152", "152", "152", "152", "152", "152", "152", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102", "102"})
        Me.British_Standard_UEA_FDA_flange_breadth.Location = New System.Drawing.Point(384, 288)
        Me.British_Standard_UEA_FDA_flange_breadth.Name = "British_Standard_UEA_FDA_flange_breadth"
        Me.British_Standard_UEA_FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.British_Standard_UEA_FDA_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.British_Standard_UEA_FDA_flange_breadth.TabIndex = 27
        Me.British_Standard_UEA_FDA_flange_breadth.Visible = False
        '
        'Standard_Blades_names
        '
        Me.Standard_Blades_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Standard_Blades_names.ItemHeight = 16
        Me.Standard_Blades_names.Items.AddRange(New Object() {"50.0 x 6.0 FB", "50.0 x 7.0 FB", "50.0 x 8.0 FB", "50.0 x 9.0 FB", "50.0 x 10.0 FB", "50.0 x 11.0 FB", "50.0 x 12.0 FB", "50.0 x 13.0 FB", "50.0 x 14.0 FB", "65.0 x 6.0 FB", "65.0 x 7.0 FB", "65.0 x 8.0 FB", "65.0 x 9.0 FB", "65.0 x 10.0 FB", "65.0 x 11.0 FB", "65.0 x 12.0 FB", "65.0 x 12.0 FB", "65.0 x 13.0 FB", "65.0 x 14.0 FB", "75.0 x 6.0 FB", "75.0 x 7.0 FB", "75.0 x 8.0 FB", "75.0 x 9.0 FB", "75.0 x 10.0 FB", "75.0 x 11.0 FB", "75.0 x 12.0 FB", "75.0 x 13.0 FB", "75.0 x 14.0 FB", "90.0 x 6.0 FB", "90.0 x 7.0 FB", "90.0 x 8.0 FB", "90.0 x 9.0 FB", "90.0 x 10.0 FB", "90.0 x 11.0 FB", "90.0 x 12.0 FB", "90.0 x 12.0 FB", "90.0 x 13.0 FB", "90.0 x 14.0 FB", "100.0 x 6.0 FB", "100.0 x 7.0 FB", "100.0 x 8.0 FB", "100.0 x 9.0 FB", "100.0 x 10.0 FB", "100.0 x 11.0 FB", "100.0 x 12.0 FB", "100.0 x 12.0 FB", "100.0 x 13.0 FB", "100.0 x 14.0 FB", "125.0 x 6.0 FB", "125.0 x 7.0 FB", "125.0 x 8.0 FB", "125.0 x 9.0 FB", "125.0 x 10.0 FB", "125.0 x 11.0 FB", "125.0 x 12.0 FB", "125.0 x 12.0 FB", "125.0 x 13.0 FB", "125.0 x 14.0 FB", "150.0 x 6.0 FB", "150.0 x 7.0 FB", "150.0 x 8.0 FB", "150.0 x 9.0 FB", "150.0 x 10.0 FB", "150.0 x 11.0 FB", "150.0 x 12.0 FB", "150.0 x 12.0 FB", "150.0 x 13.0 FB", "150.0 x 14.0 FB"})
        Me.Standard_Blades_names.Location = New System.Drawing.Point(15, 46)
        Me.Standard_Blades_names.Name = "Standard_Blades_names"
        Me.Standard_Blades_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Standard_Blades_names.Size = New System.Drawing.Size(189, 276)
        Me.Standard_Blades_names.TabIndex = 73
        '
        'Polish_Standard_UIA_FDA_names
        '
        Me.Polish_Standard_UIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Polish_Standard_UIA_FDA_names.ItemHeight = 16
        Me.Polish_Standard_UIA_FDA_names.Items.AddRange(New Object() {"30.0 x 20.0 x 3.0/3.0 IA", "30.0 x 20.0 x 4.0/4.0 IA", "40.0 x 20.0 x 3.0/3.0 IA", "40.0 x 20.0 x 4.0/4.0 IA", "40.0 x 25.0 x 4.0/4.0 IA", "45.0 x 30.0 x 3.0/3.0 IA", "45.0 x 30.0 x 4.0/4.0 IA", "45.0 x 30.0 x 5.0/5.0 IA", "50.0 x 30.0 x 4.0/4.0 IA", "50.0 x 30.0 x 5.0/5.0 IA", "50.0 x 40.0 x 4.0/4.0 IA", "50.0 x 40.0 x 5.0/5.0 IA", "60.0 x 30.0 x 5.0/5.0 IA", "60.0 x 40.0 x 5.0/5.0 IA", "60.0 x 40.0 x 6.0/6.0 IA", "60.0 x 40.0 x 7.0/7.0 IA", "65.0 x 50.0 x 5.0/5.0 IA", "65.0 x 50.0 x 7.0/7.0 IA", "65.0 x 50.0 x 9.0/9.0 IA", "70.0 x 50.0 x 6.0/6.0 IA", "75.0 x 50.0 x 7.0/7.0 IA", "75.0 x 50.0 x 9.0/9.0 IA", "75.0 x 55.0 x 5.0/5.0 IA", "75.0 x 55.0 x 7.0/7.0 IA", "75.0 x 55.0 x 9.0/9.0 IA", "80.0 x 40.0 x 6.0/6.0 IA", "80.0 x 40.0 x 8.0/8.0 IA", "80.0 x 60.0 x 7.0/7.0 IA", "80.0 x 65.0 x 8.0/8.0 IA", "80.0 x 65.0 x 10.0/10.0 IA", "90.0 x 60.0 x 6.0/6.0 IA", "90.0 x 60.0 x 8.0/8.0 IA", "100.0 x 50.0 x 6.0/6.0 IA", "100.0 x 50.0 x 8.0/8.0 IA", "100.0 x 50.0 x 10.0/10.0 IA", "100.0 x 65.0 x 7.0/7.0 IA", "100.0 x 65.0 x 9.0/9.0 IA", "100.0 x 65.0 x 11.0/11.0 IA", "100.0 x 75.0 x 7.0/7.0 IA", "100.0 x 75.0 x 9.0/9.0 IA", "100.0 x 75.0 x 11.0/11.0 IA", "120.0 x 80.0 x 8.0/8.0 IA", "120.0 x 80.0 x 10.0/10.0 IA", "120.0 x 80.0 x 12.0/12.0 IA", "130.0 x 65.0 x 8.0/8.0 IA", "130.0 x 65.0 x 10.0/10.0 IA", "130.0 x 65.0 x 12.0/12.0 IA", "130.0 x 90.0 x 12.0/12.0 IA", "150.0 x 75.0 x 9.0/9.0 IA", "150.0 x 75.0 x 11.0/11.0 IA", "150.0 x 100.0 x 10.0/10.0 IA", "150.0 x 100.0 x 12.0/12.0 IA", "150.0 x 100.0 x 14.0/14.0 IA", "160.0 x 80.0 x 12.0/12.0 IA", "180.0 x 90.0 x 10.0/10.0 IA", "180.0 x 90.0 x 12.0/12.0 IA", "200.0 x 100.0 x 10.0/10.0 IA", "200.0 x 100.0 x 12.0/12.0 IA", "200.0 x 100.0 x 14.0/14.0 IA"})
        Me.Polish_Standard_UIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.Polish_Standard_UIA_FDA_names.Name = "Polish_Standard_UIA_FDA_names"
        Me.Polish_Standard_UIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_UIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.Polish_Standard_UIA_FDA_names.TabIndex = 68
        '
        'Polish_Standard_EIA_FDA_names
        '
        Me.Polish_Standard_EIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Polish_Standard_EIA_FDA_names.ItemHeight = 16
        Me.Polish_Standard_EIA_FDA_names.Items.AddRange(New Object() {"20.0 x 20.0 x 3.0/3.0 IA", "25.0 x 25.0 x 3.0/3.0 IA", "30.0 x 30.0 x 3.0/3.0 IA", "30.0 x 30.0 x 4.0/4.0 IA", "35.0 x 35.0 x 4.0/4.0 IA", "35.0 x 35.0 x 5.0/5.0 IA", "40.0 x 40.0 x 4.0/4.0 IA", "40.0 x 40.0 x 5.0/5.0 IA", "45.0 x 45.0 x 4.0/4.0 IA", "45.0 x 45.0 x 5.0/5.0 IA", "50.0 x 50.0 x 4.0/4.0 IA", "50.0 x 50.0 x 5.0/5.0 IA", "50.0 x 50.0 x 6.0/6.0 IA", "60.0 x 60.0 x 5.0/5.0 IA", "60.0 x 60.0 x 6.0/6.0 IA", "60.0 x 60.0 x 8.0/8.0 IA", "65.0 x 65.0 x 6.0/6.0 IA", "65.0 x 65.0 x 7.0/7.0 IA", "65.0 x 65.0 x 9.0/9.0 IA", "75.0 x 75.0 x 5.0/5.0 IA", "75.0 x 75.0 x 6.0/6.0 IA", "75.0 x 75.0 x 7.0/7.0 IA", "75.0 x 75.0 x 8.0/8.0 IA", "75.0 x 75.0 x 9.0/9.0 IA", "80.0 x 80.0 x 6.0/6.0 IA", "80.0 x 80.0 x 8.0/8.0 IA", "80.0 x 80.0 x 10.0/10.0 IA", "90.0 x 90.0 x 6.0/6.0 IA", "90.0 x 90.0 x 7.0/7.0 IA", "90.0 x 90.0 x 8.0/8.0 IA", "90.0 x 90.0 x 9.0/9.0 IA", "90.0 x 90.0 x 10.0/10.0 IA", "90.0 x 90.0 x 11.0/11.0 IA", "100.0 x 100.0 x 8.0/8.0 IA", "100.0 x 100.0 x 10.0/10.0 IA", "100.0 x 100.0 x 12.0/12.0 IA", "120.0 x 120.0 x 10.0/10.0 IA", "120.0 x 120.0 x 12.0/12.0 IA", "130.0 x 130.0 x 12.0/12.0 IA", "150.0 x 150.0 x 12.0/12.0 IA", "150.0 x 150.0 x 15.0/15.0 IA", "160.0 x 160.0 x 12.0/12.0 IA", "160.0 x 160.0 x 15.0/15.0 IA", "180.0 x 180.0 x 16.0/16.0 IA", "180.0 x 180.0 x 18.0/18.0 IA", "200.0 x 200.0 x 20.0/20.0 IA"})
        Me.Polish_Standard_EIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.Polish_Standard_EIA_FDA_names.Name = "Polish_Standard_EIA_FDA_names"
        Me.Polish_Standard_EIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Polish_Standard_EIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.Polish_Standard_EIA_FDA_names.TabIndex = 67
        '
        'Korean_Standard_EIA_FDA_names
        '
        Me.Korean_Standard_EIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Korean_Standard_EIA_FDA_names.ItemHeight = 16
        Me.Korean_Standard_EIA_FDA_names.Items.AddRange(New Object() {"25.0 x 25.0 x 3.0/3.0 IA", "30.0 x 30.0 x 3.0/3.0 IA", "40.0 x 40.0 x 3.0/3.0 IA", "40.0 x 40.0 x 5.0/5.0 IA", "45.0 x 45.0 x 4.0/4.0 IA", "45.0 x 45.0 x 5.0/5.0 IA", "50.0 x 50.0 x 4.0/4.0 IA", "50.0 x 50.0 x 5.0/5.0 IA", "50.0 x 50.0 x 6.0/6.0 IA", "60.0 x 60.0 x 4.0/4.0 IA", "60.0 x 60.0 x 5.0/5.0 IA", "65.0 x 65.0 x 5.0/5.0 IA", "65.0 x 65.0 x 6.0/6.0 IA", "65.0 x 65.0 x 8.0/8.0 IA", "70.0 x 70.0 x 6.0/6.0 IA", "75.0 x 75.0 x 6.0/6.0 IA", "75.0 x 75.0 x 9.0/9.0 IA", "75.0 x 75.0 x 12.0/12.0 IA", "80.0 x 80.0 x 6.0/6.0 IA", "90.0 x 90.0 x 6.0/6.0 IA", "90.0 x 90.0 x 7.0/7.0 IA", "90.0 x 90.0 x 10.0/10.0 IA", "90.0 x 90.0 x 13.0/13.0 IA", "100.0 x 100.0 x 7.0/7.0 IA", "100.0 x 100.0 x 10.0/10.0 IA", "100.0 x 100.0 x 13.0/13.0 IA", "120.0 x 120.0 x 8.0/8.0 IA", "130.0 x 130.0 x 9.0/9.0 IA", "130.0 x 130.0 x 12.0/12.0 IA", "130.0 x 130.0 x 15.0/15.0 IA", "150.0 x 150.0 x 12.0/12.0 IA", "150.0 x 150.0 x 15.0/15.0 IA", "150.0 x 150.0 x 19.0/19.0 IA", "175.0 x 175.0 x 12.0/12.0 IA", "175.0 x 175.0 x 15.0/15.0 IA", "200.0 x 200.0 x 15.0/15.0 IA", "200.0 x 200.0 x 20.0/20.0 IA", "200.0 x 200.0 x 25.0/25.0 IA", "250.0 x 250.0 x 25.0/25.0 IA", "250.0 x 250.0 x 35.0/35.0 IA"})
        Me.Korean_Standard_EIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.Korean_Standard_EIA_FDA_names.Name = "Korean_Standard_EIA_FDA_names"
        Me.Korean_Standard_EIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Korean_Standard_EIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.Korean_Standard_EIA_FDA_names.TabIndex = 62
        '
        'Japanese_Standard_EIA_FDA_names
        '
        Me.Japanese_Standard_EIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Japanese_Standard_EIA_FDA_names.ItemHeight = 16
        Me.Japanese_Standard_EIA_FDA_names.Items.AddRange(New Object() {"50.0 x 50.0 x 6.0/6.0 IA", "65.0 x 65.0 x 6.0/6.0 IA", "65.0 x 65.0 x 8.0/8.0 IA", "75.0 x 75.0 x 6.0/6.0 IA", "75.0 x 75.0 x 9.0/9.0 IA", "75.0 x 75.0 x 12.0/12.0 IA", "90.0 x 90.0 x 6.0/6.0 IA", "90.0 x 90.0 x 7.0/7.0 IA", "90.0 x 90.0 x 10.0/10.0 IA", "90.0 x 90.0 x 13.0/13.0 IA", "100.0 x 100.0 x 7.0/7.0 IA", "100.0 x 100.0 x 10.0/10.0 IA", "100.0 x 100.0 x 13.0/13.0 IA", "130.0 x 130.0 x 9.0/9.0 IA", "130.0 x 130.0 x 12.0/12.0 IA", "130.0 x 130.0 x 15.0/15.0 IA", "150.0 x 150.0 x 10.0/10.0 IA", "150.0 x 150.0 x 12.0/12.0 IA", "150.0 x 150.0 x 15.0/15.0 IA", "150.0 x 150.0 x 19.0/19.0 IA", "175.0 x 175.0 x 12.0/12.0 IA", "175.0 x 175.0 x 15.0/15.0 IA", "200.0 x 200.0 x 15.0/15.0 IA", "200.0 x 200.0 x 20.0/20.0 IA", "200.0 x 200.0 x 25.0/25.0 IA", "200.0 x 200.0 x 29.0/29.0 IA", "250.0 x 250.0 x 25.0/25.0 IA", "250.0 x 250.0 x 35.0/35.0 IA"})
        Me.Japanese_Standard_EIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.Japanese_Standard_EIA_FDA_names.Name = "Japanese_Standard_EIA_FDA_names"
        Me.Japanese_Standard_EIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japanese_Standard_EIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.Japanese_Standard_EIA_FDA_names.TabIndex = 53
        '
        'ISO_Standard_UIA_FDA_names
        '
        Me.ISO_Standard_UIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ISO_Standard_UIA_FDA_names.ItemHeight = 16
        Me.ISO_Standard_UIA_FDA_names.Items.AddRange(New Object() {"30.0 x 20.0 x 3.0/3.0 IA", "30.0 x 20.0 x 4.0/4.0 IA", "40.0 x 25.0 x 4.0/4.0 IA", "40.0 x 25.0 x 5.0/5.0 IA", "40.0 x 25.0 x 6.0/6.0 IA", "45.0 x 30.0 x 4.0/4.0 IA", "45.0 x 30.0 x 5.0/5.0 IA", "60.0 x 40.0 x 5.0/5.0 IA", "60.0 x 40.0 x 6.0/6.0 IA", "65.0 x 50.0 x 5.0/5.0 IA", "65.0 x 50.0 x 6.0/6.0 IA", "65.0 x 50.0 x 7.0/7.0 IA", "65.0 x 50.0 x 8.0/8.0 IA", "70.0 x 50.0 x 7.0/7.0 IA", "75.0 x 50.0 x 5.0/5.0 IA", "75.0 x 50.0 x 6.0/6.0 IA", "75.0 x 50.0 x 7.0/7.0 IA", "75.0 x 50.0 x 8.0/8.0 IA", "80.0 x 40.0 x 6.0/6.0 IA", "80.0 x 60.0 x 6.0/6.0 IA", "80.0 x 60.0 x 7.0/7.0 IA", "80.0 x 60.0 x 8.0/8.0 IA", "80.0 x 65.0 x 10.0/10.0 IA", "90.0 x 60.0 x 8.0/8.0 IA", "100.0 x 50.0 x 8.0/8.0 IA", "100.0 x 65.0 x 7.0/7.0 IA", "100.0 x 65.0 x 8.0/8.0 IA", "100.0 x 65.0 x 10.0/10.0 IA", "100.0 x 75.0 x 8.0/8.0 IA", "120.0 x 80.0 x 8.0/8.0 IA", "120.0 x 80.0 x 10.0/10.0 IA", "120.0 x 80.0 x 12.0/12.0 IA", "130.0 x 65.0 x 10.0/10.0 IA", "150.0 x 100.0 x 10.0/10.0 IA", "150.0 x 100.0 x 12.0/12.0 IA", "200.0 x 100.0 x 10.0/10.0 IA", "200.0 x 100.0 x 12.0/12.0 IA"})
        Me.ISO_Standard_UIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.ISO_Standard_UIA_FDA_names.Name = "ISO_Standard_UIA_FDA_names"
        Me.ISO_Standard_UIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_UIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.ISO_Standard_UIA_FDA_names.TabIndex = 48
        '
        'FDA01_pic
        '
        Me.FDA01_pic.Controls.Add(Me.FDA_flange_thickness)
        Me.FDA01_pic.Controls.Add(Me.FDA_flange_breadth)
        Me.FDA01_pic.Controls.Add(Me.FDA_profile_depth)
        Me.FDA01_pic.Controls.Add(Me.FDA_web_depth)
        Me.FDA01_pic.Controls.Add(Me.FDA_web_thickness)
        Me.FDA01_pic.Controls.Add(Me.PictureBox3)
        Me.FDA01_pic.Location = New System.Drawing.Point(580, 40)
        Me.FDA01_pic.Name = "FDA01_pic"
        Me.FDA01_pic.Size = New System.Drawing.Size(276, 280)
        Me.FDA01_pic.TabIndex = 23
        Me.FDA01_pic.TabStop = False
        Me.FDA01_pic.Text = "FDA01"
        '
        'FDA_flange_thickness
        '
        Me.FDA_flange_thickness.AutoEllipsis = True
        Me.FDA_flange_thickness.BackColor = System.Drawing.Color.Transparent
        Me.FDA_flange_thickness.Location = New System.Drawing.Point(9, 58)
        Me.FDA_flange_thickness.Name = "FDA_flange_thickness"
        Me.FDA_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_flange_thickness.Size = New System.Drawing.Size(66, 26)
        Me.FDA_flange_thickness.TabIndex = 15
        Me.FDA_flange_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FDA_flange_breadth
        '
        Me.FDA_flange_breadth.AutoEllipsis = True
        Me.FDA_flange_breadth.BackColor = System.Drawing.Color.Transparent
        Me.FDA_flange_breadth.Location = New System.Drawing.Point(127, 20)
        Me.FDA_flange_breadth.Name = "FDA_flange_breadth"
        Me.FDA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_flange_breadth.Size = New System.Drawing.Size(72, 20)
        Me.FDA_flange_breadth.TabIndex = 14
        Me.FDA_flange_breadth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FDA_profile_depth
        '
        Me.FDA_profile_depth.AutoEllipsis = True
        Me.FDA_profile_depth.BackColor = System.Drawing.Color.Transparent
        Me.FDA_profile_depth.Location = New System.Drawing.Point(146, 112)
        Me.FDA_profile_depth.Name = "FDA_profile_depth"
        Me.FDA_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_profile_depth.Size = New System.Drawing.Size(77, 20)
        Me.FDA_profile_depth.TabIndex = 13
        Me.FDA_profile_depth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FDA_web_depth
        '
        Me.FDA_web_depth.AutoEllipsis = True
        Me.FDA_web_depth.BackColor = System.Drawing.Color.Transparent
        Me.FDA_web_depth.Location = New System.Drawing.Point(6, 112)
        Me.FDA_web_depth.Name = "FDA_web_depth"
        Me.FDA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_web_depth.Size = New System.Drawing.Size(71, 28)
        Me.FDA_web_depth.TabIndex = 12
        Me.FDA_web_depth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FDA_web_thickness
        '
        Me.FDA_web_thickness.AutoEllipsis = True
        Me.FDA_web_thickness.BackColor = System.Drawing.Color.Transparent
        Me.FDA_web_thickness.Location = New System.Drawing.Point(62, 213)
        Me.FDA_web_thickness.Name = "FDA_web_thickness"
        Me.FDA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_web_thickness.Size = New System.Drawing.Size(80, 20)
        Me.FDA_web_thickness.TabIndex = 11
        Me.FDA_web_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(83, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'FDA01_blade_pic
        '
        Me.FDA01_blade_pic.Controls.Add(Me.Standard_Blades_profiles_depth_label)
        Me.FDA01_blade_pic.Controls.Add(Me.Standard_Blades_web_thickness_label)
        Me.FDA01_blade_pic.Controls.Add(Me.PictureBox4)
        Me.FDA01_blade_pic.Location = New System.Drawing.Point(580, 40)
        Me.FDA01_blade_pic.Name = "FDA01_blade_pic"
        Me.FDA01_blade_pic.Size = New System.Drawing.Size(276, 280)
        Me.FDA01_blade_pic.TabIndex = 76
        Me.FDA01_blade_pic.TabStop = False
        Me.FDA01_blade_pic.Text = "Profile: British Standard EA"
        '
        'Standard_Blades_profiles_depth_label
        '
        Me.Standard_Blades_profiles_depth_label.AutoEllipsis = True
        Me.Standard_Blades_profiles_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.Standard_Blades_profiles_depth_label.Location = New System.Drawing.Point(34, 124)
        Me.Standard_Blades_profiles_depth_label.Name = "Standard_Blades_profiles_depth_label"
        Me.Standard_Blades_profiles_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Standard_Blades_profiles_depth_label.Size = New System.Drawing.Size(76, 21)
        Me.Standard_Blades_profiles_depth_label.TabIndex = 12
        Me.Standard_Blades_profiles_depth_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Standard_Blades_web_thickness_label
        '
        Me.Standard_Blades_web_thickness_label.AutoEllipsis = True
        Me.Standard_Blades_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.Standard_Blades_web_thickness_label.Location = New System.Drawing.Point(112, 240)
        Me.Standard_Blades_web_thickness_label.Name = "Standard_Blades_web_thickness_label"
        Me.Standard_Blades_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Standard_Blades_web_thickness_label.Size = New System.Drawing.Size(79, 20)
        Me.Standard_Blades_web_thickness_label.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(115, 28)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(65, 208)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'box01
        '
        Me.box01.Controls.Add(Me.Label_y01_unit)
        Me.box01.Controls.Add(Me.textbox_a01)
        Me.box01.Controls.Add(Me.Label_a01_unit)
        Me.box01.Controls.Add(Me.textbox_y01)
        Me.box01.Controls.Add(Me.Label_m01_unit)
        Me.box01.Controls.Add(Me.textbox_m01)
        Me.box01.Controls.Add(Me.Label_y01)
        Me.box01.Controls.Add(Me.Label_a01)
        Me.box01.Controls.Add(Me.Label_m01)
        Me.box01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.box01.Location = New System.Drawing.Point(207, 38)
        Me.box01.Name = "box01"
        Me.box01.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box01.Size = New System.Drawing.Size(364, 136)
        Me.box01.TabIndex = 25
        Me.box01.TabStop = False
        Me.box01.Text = "נתוני החיזוק"
        '
        'Label_y01_unit
        '
        Me.Label_y01_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_y01_unit.Location = New System.Drawing.Point(16, 94)
        Me.Label_y01_unit.Name = "Label_y01_unit"
        Me.Label_y01_unit.Size = New System.Drawing.Size(56, 25)
        Me.Label_y01_unit.TabIndex = 8
        Me.Label_y01_unit.Text = "[cm]"
        '
        'textbox_a01
        '
        Me.textbox_a01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a01.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a01.Name = "textbox_a01"
        Me.textbox_a01.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a01.TabIndex = 7
        '
        'Label_a01_unit
        '
        Me.Label_a01_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_a01_unit.Location = New System.Drawing.Point(16, 63)
        Me.Label_a01_unit.Name = "Label_a01_unit"
        Me.Label_a01_unit.Size = New System.Drawing.Size(56, 25)
        Me.Label_a01_unit.TabIndex = 6
        Me.Label_a01_unit.Text = "[cm^2]"
        '
        'textbox_y01
        '
        Me.textbox_y01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y01.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y01.Name = "textbox_y01"
        Me.textbox_y01.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y01.TabIndex = 5
        '
        'Label_m01_unit
        '
        Me.Label_m01_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_m01_unit.Location = New System.Drawing.Point(16, 32)
        Me.Label_m01_unit.Name = "Label_m01_unit"
        Me.Label_m01_unit.Size = New System.Drawing.Size(56, 25)
        Me.Label_m01_unit.TabIndex = 4
        Me.Label_m01_unit.Text = "[cm^4]"
        '
        'textbox_m01
        '
        Me.textbox_m01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m01.Location = New System.Drawing.Point(91, 32)
        Me.textbox_m01.Name = "textbox_m01"
        Me.textbox_m01.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m01.TabIndex = 3
        '
        'Label_y01
        '
        Me.Label_y01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_y01.Location = New System.Drawing.Point(188, 94)
        Me.Label_y01.Name = "Label_y01"
        Me.Label_y01.Size = New System.Drawing.Size(164, 24)
        Me.Label_y01.TabIndex = 2
        Me.Label_y01.Text = "מיקום מרכז שטח (Y)"
        '
        'Label_a01
        '
        Me.Label_a01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_a01.Location = New System.Drawing.Point(188, 63)
        Me.Label_a01.Name = "Label_a01"
        Me.Label_a01.Size = New System.Drawing.Size(164, 25)
        Me.Label_a01.TabIndex = 1
        Me.Label_a01.Text = "שטח חתך החיזוק"
        '
        'Label_m01
        '
        Me.Label_m01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_m01.Location = New System.Drawing.Point(188, 32)
        Me.Label_m01.Name = "Label_m01"
        Me.Label_m01.Size = New System.Drawing.Size(164, 25)
        Me.Label_m01.TabIndex = 0
        Me.Label_m01.Text = "מומנט אינרציה (Ix)"
        '
        'ISO_Standard_EIA_FDA_names
        '
        Me.ISO_Standard_EIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ISO_Standard_EIA_FDA_names.ItemHeight = 16
        Me.ISO_Standard_EIA_FDA_names.Items.AddRange(New Object() {"20.0 x 20.0 x 3.0/3.0 IA", "25.0 x 25.0 x 3.0/3.0 IA", "25.0 x 25.0 x 4.0/4.0 IA", "30.0 x 30.0 x 3.0/3.0 IA", "30.0 x 30.0 x 4.0/4.0 IA", "35.0 x 35.0 x 4.0/4.0 IA", "35.0 x 35.0 x 5.0/5.0 IA", "40.0 x 40.0 x 3.0/3.0 IA", "40.0 x 40.0 x 4.0/4.0 IA", "40.0 x 40.0 x 5.0/5.0 IA", "45.0 x 45.0 x 4.0/4.0 IA", "45.0 x 45.0 x 5.0/5.0 IA", "50.0 x 50.0 x 4.0/4.0 IA", "50.0 x 50.0 x 5.0/5.0 IA", "50.0 x 50.0 x 6.0/6.0 IA", "60.0 x 60.0 x 5.0/5.0 IA", "60.0 x 60.0 x 6.0/6.0 IA", "60.0 x 60.0 x 8.0/8.0 IA", "65.0 x 65.0 x 6.0/6.0 IA", "65.0 x 65.0 x 8.0/8.0 IA", "70.0 x 70.0 x 6.0/6.0 IA", "70.0 x 70.0 x 7.0/7.0 IA", "75.0 x 75.0 x 6.0/6.0 IA", "75.0 x 75.0 x 8.0/8.0 IA", "80.0 x 80.0 x 6.0/6.0 IA", "80.0 x 80.0 x 8.0/8.0 IA", "80.0 x 80.0 x 10.0/10.0 IA", "90.0 x 90.0 x 7.0/7.0 IA", "90.0 x 90.0 x 8.0/8.0 IA", "90.0 x 90.0 x 9.0/9.0 IA", "90.0 x 90.0 x 10.0/10.0 IA", "100.0 x 100.0 x 8.0/8.0 IA", "100.0 x 100.0 x 10.0/10.0 IA", "100.0 x 100.0 x 12.0/12.0 IA", "120.0 x 120.0 x 8.0/8.0 IA", "120.0 x 120.0 x 10.0/10.0 IA", "120.0 x 120.0 x 12.0/12.0 IA", "125.0 x 125.0 x 8.0/8.0 IA", "125.0 x 125.0 x 10.0/10.0 IA", "125.0 x 125.0 x 12.0/12.0 IA", "150.0 x 150.0 x 10.0/10.0 IA", "150.0 x 150.0 x 12.0/12.0 IA", "150.0 x 150.0 x 15.0/15.0 IA", "180.0 x 180.0 x 15.0/15.0 IA", "180.0 x 180.0 x 18.0/18.0 IA", "200.0 x 200.0 x 16.0/16.0 IA", "200.0 x 200.0 x 20.0/20.0 IA", "200.0 x 200.0 x 24.0/24.0 IA", "250.0 x 250.0 x 28.0/28.0 IA", "250.0 x 250.0 x 35.0/35.0 IA"})
        Me.ISO_Standard_EIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.ISO_Standard_EIA_FDA_names.Name = "ISO_Standard_EIA_FDA_names"
        Me.ISO_Standard_EIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_Standard_EIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.ISO_Standard_EIA_FDA_names.TabIndex = 43
        '
        'European_Standard_UIA_FDA_names
        '
        Me.European_Standard_UIA_FDA_names.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.European_Standard_UIA_FDA_names.ItemHeight = 16
        Me.European_Standard_UIA_FDA_names.Items.AddRange(New Object() {"25.0 x 16.0 x 3.0/3.0 IA", "30.0 x 20.0 x 3.0/3.0 IA", "30.0 x 20.0 x 4.0/4.0 IA", "32.0 x 20.0 x 3.0/3.0 IA", "32.0 x 20.0 x 4.0/4.0 IA", "40.0 x 25.0 x 3.0/3.0 IA", "40.0 x 25.0 x 4.0/4.0 IA", "45.0 x 28.0 x 3.0/3.0 IA", "45.0 x 28.0 x 4.0/4.0 IA", "45.0 x 30.0 x 4.0/4.0 IA", "45.0 x 30.0 x 6.0/6.0 IA", "50.0 x 32.0 x 3.0/3.0 IA", "50.0 x 32.0 x 4.0/4.0 IA", "56.0 x 36.0 x 3.5/3.5 IA", "56.0 x 36.0 x 4.0/4.0 IA", "56.0 x 36.0 x 5.0/5.0 IA", "60.0 x 40.0 x 5.0/5.0 IA", "60.0 x 40.0 x 6.0/6.0 IA", "60.0 x 40.0 x 8.0/8.0 IA", "63.0 x 40.0 x 4.0/4.0 IA", "63.0 x 40.0 x 5.0/5.0 IA", "63.0 x 40.0 x 6.0/6.0 IA", "63.0 x 40.0 x 8.0/8.0 IA", "70.0 x 45.0 x 4.5/4.5 IA", "70.0 x 45.0 x 5.0/5.0 IA", "75.0 x 50.0 x 5.0/5.0 IA", "75.0 x 50.0 x 6.0/6.0 IA", "75.0 x 50.0 x 8.0/8.0 IA", "75.0 x 50.0 x 10.0/10.0 IA", "80.0 x 50.0 x 5.0/5.0 IA", "80.0 x 50.0 x 6.0/6.0 IA", "80.0 x 55.0 x 6.0/6.0 IA", "80.0 x 55.0 x 8.0/8.0 IA", "80.0 x 55.0 x 10.0/10.0 IA", "90.0 x 56.0 x 5.5/5.5 IA", "90.0 x 56.0 x 6.0/6.0 IA", "90.0 x 56.0 x 8.0/8.0 IA", "90.0 x 60.0 x 6.0/6.0 IA", "90.0 x 60.0 x 8.0/8.0 IA", "90.0 x 60.0 x 10.0/10.0 IA", "100.0 x 63.0 x 6.0/6.0 IA", "100.0 x 63.0 x 7.0/7.0 IA", "100.0 x 63.0 x 8.0/8.0 IA", "100.0 x 63.0 x 10.0/10.0 IA", "100.0 x 75.0 x 8.0/8.0 IA", "100.0 x 75.0 x 10.0/10.0 IA", "100.0 x 75.0 x 12.0/12.0 IA", "110.0 x 70.0 x 6.5/6.5 IA", "110.0 x 70.0 x 7.0/7.0 IA", "110.0 x 70.0 x 8.0/8.0 IA", "120.0 x 80.0 x 8.0/8.0 IA", "120.0 x 80.0 x 10.0/10.0 IA", "120.0 x 80.0 x 12.0/12.0 IA", "125.0 x 80.0 x 7.0/7.0 IA", "125.0 x 80.0 x 8.0/8.0 IA", "125.0 x 80.0 x 10.0/10.0 IA", "125.0 x 80.0 x 12.0/12.0 IA", "130.0 x 90.0 x 8.0/8.0 IA", "130.0 x 90.0 x 10.0/10.0 IA", "130.0 x 90.0 x 12.0/12.0 IA", "130.0 x 90.0 x 14.0/14.0 IA", "140.0 x 90.0 x 8.0/8.0 IA", "140.0 x 90.0 x 10.0/10.0 IA", "150.0 x 100.0 x 10.0/10.0 IA", "150.0 x 100.0 x 12.0/12.0 IA", "150.0 x 100.0 x 14.0/14.0 IA", "150.0 x 100.0 x 16.0/16.0 IA", "160.0 x 100.0 x 9.0/9.0 IA", "160.0 x 100.0 x 10.0/10.0 IA", "160.0 x 100.0 x 12.0/12.0 IA", "160.0 x 100.0 x 14.0/14.0 IA", "180.0 x 110.0 x 10.0/10.0 IA", "180.0 x 110.0 x 12.0/12.0 IA", "180.0 x 120.0 x 12.0/12.0 IA", "180.0 x 120.0 x 14.0/14.0 IA", "180.0 x 120.0 x 16.0/16.0 IA", "200.0 x 120.0 x 12.0/12.0 IA", "200.0 x 120.0 x 14.0/14.0 IA", "200.0 x 120.0 x 16.0/16.0 IA", "200.0 x 125.0 x 11.0/11.0 IA", "200.0 x 125.0 x 12.0/12.0 IA", "200.0 x 125.0 x 14.0/14.0 IA", "200.0 x 150.0 x 12.0/12.0 IA", "200.0 x 150.0 x 16.0/16.0 IA", "200.0 x 150.0 x 18.0/18.0 IA", "250.0 x 160.0 x 12.0/12.0 IA", "250.0 x 160.0 x 16.0/16.0 IA", "250.0 x 160.0 x 18.0/18.0 IA", "250.0 x 160.0 x 20.0/20.0 IA"})
        Me.European_Standard_UIA_FDA_names.Location = New System.Drawing.Point(15, 46)
        Me.European_Standard_UIA_FDA_names.Name = "European_Standard_UIA_FDA_names"
        Me.European_Standard_UIA_FDA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.European_Standard_UIA_FDA_names.Size = New System.Drawing.Size(189, 276)
        Me.European_Standard_UIA_FDA_names.TabIndex = 38
        '
        'box_standard
        '
        Me.box_standard.Controls.Add(Me.british)
        Me.box_standard.Controls.Add(Me.DIN_link)
        Me.box_standard.Controls.Add(Me.DIN)
        Me.box_standard.Controls.Add(Me.ISO_link)
        Me.box_standard.Controls.Add(Me.ISO)
        Me.box_standard.Controls.Add(Me.inexa_link)
        Me.box_standard.Controls.Add(Me.inexa)
        Me.box_standard.Controls.Add(Me.corus_link)
        Me.box_standard.Controls.Add(Me.corus)
        Me.box_standard.Controls.Add(Me.Label_count)
        Me.box_standard.Controls.Add(Me.tekens_tree)
        Me.box_standard.Controls.Add(Me.british_link)
        Me.box_standard.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.box_standard.Location = New System.Drawing.Point(60, 52)
        Me.box_standard.Name = "box_standard"
        Me.box_standard.Size = New System.Drawing.Size(879, 184)
        Me.box_standard.TabIndex = 6
        Me.box_standard.TabStop = False
        Me.box_standard.Text = "תקנים קיימים"
        '
        'british
        '
        Me.british.Image = CType(resources.GetObject("british.Image"), System.Drawing.Image)
        Me.british.Location = New System.Drawing.Point(16, 52)
        Me.british.Name = "british"
        Me.british.Size = New System.Drawing.Size(288, 92)
        Me.british.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.british.TabIndex = 28
        Me.british.TabStop = False
        Me.british.Visible = False
        '
        'DIN_link
        '
        Me.DIN_link.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.DIN_link.Location = New System.Drawing.Point(80, 148)
        Me.DIN_link.Name = "DIN_link"
        Me.DIN_link.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_link.Size = New System.Drawing.Size(100, 20)
        Me.DIN_link.TabIndex = 27
        Me.DIN_link.TabStop = True
        Me.DIN_link.Text = "www.din.de/"
        Me.DIN_link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DIN_link.Visible = False
        '
        'DIN
        '
        Me.DIN.Image = CType(resources.GetObject("DIN.Image"), System.Drawing.Image)
        Me.DIN.Location = New System.Drawing.Point(92, 80)
        Me.DIN.Name = "DIN"
        Me.DIN.Size = New System.Drawing.Size(80, 56)
        Me.DIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DIN.TabIndex = 26
        Me.DIN.TabStop = False
        Me.DIN.Visible = False
        '
        'ISO_link
        '
        Me.ISO_link.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ISO_link.Location = New System.Drawing.Point(72, 148)
        Me.ISO_link.Name = "ISO_link"
        Me.ISO_link.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_link.Size = New System.Drawing.Size(145, 20)
        Me.ISO_link.TabIndex = 25
        Me.ISO_link.TabStop = True
        Me.ISO_link.Text = "http://www.iso.org"
        Me.ISO_link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ISO_link.Visible = False
        '
        'ISO
        '
        Me.ISO.Image = CType(resources.GetObject("ISO.Image"), System.Drawing.Image)
        Me.ISO.Location = New System.Drawing.Point(72, 56)
        Me.ISO.Name = "ISO"
        Me.ISO.Size = New System.Drawing.Size(152, 92)
        Me.ISO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ISO.TabIndex = 24
        Me.ISO.TabStop = False
        Me.ISO.Visible = False
        '
        'inexa_link
        '
        Me.inexa_link.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.inexa_link.Location = New System.Drawing.Point(69, 148)
        Me.inexa_link.Name = "inexa_link"
        Me.inexa_link.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.inexa_link.Size = New System.Drawing.Size(160, 20)
        Me.inexa_link.TabIndex = 23
        Me.inexa_link.TabStop = True
        Me.inexa_link.Text = "http://www.inexa.se/"
        Me.inexa_link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inexa_link.Visible = False
        '
        'inexa
        '
        Me.inexa.Image = CType(resources.GetObject("inexa.Image"), System.Drawing.Image)
        Me.inexa.Location = New System.Drawing.Point(74, 59)
        Me.inexa.Name = "inexa"
        Me.inexa.Size = New System.Drawing.Size(148, 88)
        Me.inexa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inexa.TabIndex = 22
        Me.inexa.TabStop = False
        Me.inexa.Visible = False
        '
        'corus_link
        '
        Me.corus_link.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.corus_link.Location = New System.Drawing.Point(16, 148)
        Me.corus_link.Name = "corus_link"
        Me.corus_link.Size = New System.Drawing.Size(256, 20)
        Me.corus_link.TabIndex = 21
        Me.corus_link.TabStop = True
        Me.corus_link.Text = "http://www.corusconstruction.com"
        Me.corus_link.Visible = False
        '
        'corus
        '
        Me.corus.Image = CType(resources.GetObject("corus.Image"), System.Drawing.Image)
        Me.corus.Location = New System.Drawing.Point(76, 56)
        Me.corus.Name = "corus"
        Me.corus.Size = New System.Drawing.Size(136, 92)
        Me.corus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.corus.TabIndex = 20
        Me.corus.TabStop = False
        Me.corus.Visible = False
        '
        'Label_count
        '
        Me.Label_count.AutoEllipsis = True
        Me.Label_count.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_count.Location = New System.Drawing.Point(8, 24)
        Me.Label_count.Name = "Label_count"
        Me.Label_count.Size = New System.Drawing.Size(321, 26)
        Me.Label_count.TabIndex = 3
        Me.Label_count.Text = "(סה""כ 1229 חיזוקים, 34 תקנים"
        '
        'tekens_tree
        '
        Me.tekens_tree.Font = New System.Drawing.Font("David", 10.8!)
        Me.tekens_tree.ImageIndex = 0
        Me.tekens_tree.ImageList = Me.ImageList_stiffeners_icons
        Me.tekens_tree.Location = New System.Drawing.Point(337, 24)
        Me.tekens_tree.Name = "tekens_tree"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "British Standard UEA"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = ""
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "DIN Standard EIA"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = ""
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "DIN Standard UIA"
        TreeNode4.ImageIndex = 1
        TreeNode4.Name = ""
        TreeNode4.SelectedImageIndex = 1
        TreeNode4.Text = "DIN Standard HBP"
        TreeNode5.ImageIndex = 2
        TreeNode5.Name = ""
        TreeNode5.SelectedImageIndex = 2
        TreeNode5.Text = "European Standard LIA"
        TreeNode6.ImageIndex = 2
        TreeNode6.Name = ""
        TreeNode6.SelectedImageIndex = 2
        TreeNode6.Text = "European Standard UIA"
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = ""
        TreeNode7.SelectedImageIndex = 2
        TreeNode7.Text = "ISO Standard EIA"
        TreeNode8.ImageIndex = 2
        TreeNode8.Name = ""
        TreeNode8.SelectedImageIndex = 2
        TreeNode8.Text = "ISO Standard LIA"
        TreeNode9.ImageIndex = 2
        TreeNode9.Name = ""
        TreeNode9.SelectedImageIndex = 2
        TreeNode9.Text = "ISO Standard UIA"
        TreeNode10.ImageIndex = 1
        TreeNode10.Name = ""
        TreeNode10.SelectedImageIndex = 1
        TreeNode10.Text = "ISO Standard HBP"
        TreeNode11.ImageIndex = 2
        TreeNode11.Name = ""
        TreeNode11.SelectedImageIndex = 2
        TreeNode11.Text = "Japanese Standard EIA"
        TreeNode12.ImageIndex = 2
        TreeNode12.Name = ""
        TreeNode12.SelectedImageIndex = 2
        TreeNode12.Text = "Japanese Standard LIA"
        TreeNode13.ImageIndex = 2
        TreeNode13.Name = ""
        TreeNode13.SelectedImageIndex = 2
        TreeNode13.Text = "Japanese Standard UIA"
        TreeNode14.ImageIndex = 2
        TreeNode14.Name = ""
        TreeNode14.SelectedImageIndex = 2
        TreeNode14.Text = "Korean Standard EIA"
        TreeNode15.ImageIndex = 2
        TreeNode15.Name = ""
        TreeNode15.SelectedImageIndex = 2
        TreeNode15.Text = "Korean Standard LIA"
        TreeNode16.ImageIndex = 2
        TreeNode16.Name = ""
        TreeNode16.SelectedImageIndex = 2
        TreeNode16.Text = "Korean Standard UIA"
        TreeNode17.ImageIndex = 2
        TreeNode17.Name = ""
        TreeNode17.SelectedImageIndex = 2
        TreeNode17.Text = "Nordic Standard LIA"
        TreeNode18.ImageIndex = 2
        TreeNode18.Name = ""
        TreeNode18.SelectedImageIndex = 2
        TreeNode18.Text = "Polish Standard EIA"
        TreeNode19.ImageIndex = 2
        TreeNode19.Name = ""
        TreeNode19.SelectedImageIndex = 2
        TreeNode19.Text = "Polish Standard UIA"
        TreeNode20.ImageIndex = 0
        TreeNode20.Name = ""
        TreeNode20.SelectedImageIndex = 0
        TreeNode20.Text = "Standard Blades"
        TreeNode21.ImageIndex = 1
        TreeNode21.Name = ""
        TreeNode21.SelectedImageIndex = 1
        TreeNode21.Text = "Bulbs (Japanese, Korean, Nordic, Polish)"
        TreeNode22.ImageIndex = 4
        TreeNode22.Name = ""
        TreeNode22.SelectedImageIndex = 4
        TreeNode22.Text = "FDA"
        TreeNode23.ImageIndex = 1
        TreeNode23.Name = ""
        TreeNode23.SelectedImageIndex = 1
        TreeNode23.Text = "British Standard Bulb"
        TreeNode24.ImageIndex = 2
        TreeNode24.Name = ""
        TreeNode24.SelectedImageIndex = 2
        TreeNode24.Text = "British Standard EA"
        TreeNode25.ImageIndex = 2
        TreeNode25.Name = ""
        TreeNode25.SelectedImageIndex = 2
        TreeNode25.Text = "British Standard UEA (Corus)"
        TreeNode26.ImageIndex = 4
        TreeNode26.Name = ""
        TreeNode26.SelectedImageIndex = 4
        TreeNode26.Text = "Corus"
        TreeNode27.ImageIndex = 2
        TreeNode27.Name = ""
        TreeNode27.SelectedImageIndex = 2
        TreeNode27.Text = "Equal Angles"
        TreeNode28.ImageIndex = 2
        TreeNode28.Name = ""
        TreeNode28.SelectedImageIndex = 2
        TreeNode28.Text = "NJA Standard"
        TreeNode29.ImageIndex = 1
        TreeNode29.Name = ""
        TreeNode29.SelectedImageIndex = 1
        TreeNode29.Text = "Jumbo Bulb Flats"
        TreeNode30.ImageIndex = 1
        TreeNode30.Name = ""
        TreeNode30.SelectedImageIndex = 1
        TreeNode30.Text = "Rolled Bulb Flats"
        TreeNode31.ImageIndex = 3
        TreeNode31.Name = ""
        TreeNode31.SelectedImageIndex = 3
        TreeNode31.Text = "T section"
        TreeNode32.ImageIndex = 4
        TreeNode32.Name = ""
        TreeNode32.SelectedImageIndex = 4
        TreeNode32.Text = "Inexa Profil"
        TreeNode33.ImageIndex = 2
        TreeNode33.Name = ""
        TreeNode33.SelectedImageIndex = 2
        TreeNode33.Text = "Equal Angles "
        TreeNode34.ImageIndex = 2
        TreeNode34.Name = ""
        TreeNode34.SelectedImageIndex = 2
        TreeNode34.Text = "Unequal Angles "
        TreeNode35.ImageIndex = 4
        TreeNode35.Name = ""
        TreeNode35.SelectedImageIndex = 4
        TreeNode35.Text = "Japan Industry Standard"
        Me.tekens_tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode26, TreeNode32, TreeNode35})
        Me.tekens_tree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tekens_tree.SelectedImageIndex = 0
        Me.tekens_tree.Size = New System.Drawing.Size(412, 144)
        Me.tekens_tree.TabIndex = 19
        '
        'ImageList_stiffeners_icons
        '
        Me.ImageList_stiffeners_icons.ImageStream = CType(resources.GetObject("ImageList_stiffeners_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_stiffeners_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_stiffeners_icons.Images.SetKeyName(0, "")
        Me.ImageList_stiffeners_icons.Images.SetKeyName(1, "")
        Me.ImageList_stiffeners_icons.Images.SetKeyName(2, "")
        Me.ImageList_stiffeners_icons.Images.SetKeyName(3, "")
        Me.ImageList_stiffeners_icons.Images.SetKeyName(4, "")
        '
        'british_link
        '
        Me.british_link.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.british_link.Location = New System.Drawing.Point(8, 148)
        Me.british_link.Name = "british_link"
        Me.british_link.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.british_link.Size = New System.Drawing.Size(304, 20)
        Me.british_link.TabIndex = 29
        Me.british_link.TabStop = True
        Me.british_link.Text = "http://www.british-europeanstandards.org"
        Me.british_link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.british_link.Visible = False
        '
        'label_title
        '
        Me.label_title.AutoEllipsis = True
        Me.label_title.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_title.Location = New System.Drawing.Point(60, 0)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(876, 49)
        Me.label_title.TabIndex = 7
        Me.label_title.Text = "בחלון זה ניתן לבחון את בסיס הנתונים עבור החיזוקים שהתוכנה מכילה. יש לבחור תקן מהר" & _
            "שימה ואז לבחור את סוג החיזוק הרצוי מהרשימה החדשה."
        '
        'inexa_profil_EA_and_NJA
        '
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_y)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_area)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_I)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_flange_thickness)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_flange_breadth)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_web_thickness)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_web_depth)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.box09)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Label_title09)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_y)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_area)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_I)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_flange_thickness)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_flange_breadth)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_web_thickness)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.Equal_Angles_web_depth)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.NJA_names)
        Me.inexa_profil_EA_and_NJA.Controls.Add(Me.IP_pic)
        Me.inexa_profil_EA_and_NJA.Location = New System.Drawing.Point(6, 12)
        Me.inexa_profil_EA_and_NJA.Name = "inexa_profil_EA_and_NJA"
        Me.inexa_profil_EA_and_NJA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.inexa_profil_EA_and_NJA.Size = New System.Drawing.Size(868, 356)
        Me.inexa_profil_EA_and_NJA.TabIndex = 8
        Me.inexa_profil_EA_and_NJA.TabStop = False
        Me.inexa_profil_EA_and_NJA.Text = "Inexa Profil - Equal Angles"
        Me.inexa_profil_EA_and_NJA.Visible = False
        '
        'NJA_y
        '
        Me.NJA_y.ItemHeight = 16
        Me.NJA_y.Items.AddRange(New Object() {"13.3", "16.3", "16.2", "16.1", "19.3", "19.1", "21.1", "21", "22.9", "22.9", "24.7", "24.7", "26.6"})
        Me.NJA_y.Location = New System.Drawing.Point(448, 260)
        Me.NJA_y.Name = "NJA_y"
        Me.NJA_y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_y.Size = New System.Drawing.Size(64, 20)
        Me.NJA_y.TabIndex = 30
        Me.NJA_y.Visible = False
        '
        'NJA_area
        '
        Me.NJA_area.ItemHeight = 16
        Me.NJA_area.Items.AddRange(New Object() {"27.7", "33", "38.2", "41.3", "44.9", "48.7", "49.5", "53.7", "54.3", "59.8", "59.1", "64.8", "71"})
        Me.NJA_area.Location = New System.Drawing.Point(448, 220)
        Me.NJA_area.Name = "NJA_area"
        Me.NJA_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_area.Size = New System.Drawing.Size(64, 20)
        Me.NJA_area.TabIndex = 29
        Me.NJA_area.Visible = False
        '
        'NJA_I
        '
        Me.NJA_I.ItemHeight = 16
        Me.NJA_I.Items.AddRange(New Object() {"1159", "2181", "2502", "2697", "4276", "4615", "5564", "6017", "7064", "7738", "8805", "9609", "11893"})
        Me.NJA_I.Location = New System.Drawing.Point(448, 176)
        Me.NJA_I.Name = "NJA_I"
        Me.NJA_I.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_I.Size = New System.Drawing.Size(64, 20)
        Me.NJA_I.TabIndex = 28
        Me.NJA_I.Visible = False
        '
        'NJA_flange_thickness
        '
        Me.NJA_flange_thickness.ItemHeight = 16
        Me.NJA_flange_thickness.Items.AddRange(New Object() {"12", "13", "15", "16", "15", "16", "14", "15", "16", "18", "18", "20", "23"})
        Me.NJA_flange_thickness.Location = New System.Drawing.Point(376, 288)
        Me.NJA_flange_thickness.Name = "NJA_flange_thickness"
        Me.NJA_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.NJA_flange_thickness.TabIndex = 27
        Me.NJA_flange_thickness.Visible = False
        '
        'NJA_flange_breadth
        '
        Me.NJA_flange_breadth.ItemHeight = 16
        Me.NJA_flange_breadth.Items.AddRange(New Object() {"90", "90", "90", "90", "100", "100", "120", "120", "120", "120", "120", "120", "120"})
        Me.NJA_flange_breadth.Location = New System.Drawing.Point(380, 264)
        Me.NJA_flange_breadth.Name = "NJA_flange_breadth"
        Me.NJA_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.NJA_flange_breadth.TabIndex = 26
        Me.NJA_flange_breadth.Visible = False
        '
        'NJA_web_thickness
        '
        Me.NJA_web_thickness.ItemHeight = 16
        Me.NJA_web_thickness.Items.AddRange(New Object() {"9", "9", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "11.5"})
        Me.NJA_web_thickness.Location = New System.Drawing.Point(380, 220)
        Me.NJA_web_thickness.Name = "NJA_web_thickness"
        Me.NJA_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.NJA_web_thickness.TabIndex = 25
        Me.NJA_web_thickness.Visible = False
        '
        'NJA_web_depth
        '
        Me.NJA_web_depth.ItemHeight = 16
        Me.NJA_web_depth.Items.AddRange(New Object() {"188", "237", "235", "234", "285", "284", "311", "310", "334", "332", "357", "355", "377"})
        Me.NJA_web_depth.Location = New System.Drawing.Point(380, 180)
        Me.NJA_web_depth.Name = "NJA_web_depth"
        Me.NJA_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.NJA_web_depth.TabIndex = 24
        Me.NJA_web_depth.Visible = False
        '
        'box09
        '
        Me.box09.Controls.Add(Me.label_y09_unit)
        Me.box09.Controls.Add(Me.textbox_y09)
        Me.box09.Controls.Add(Me.label_a09_unit)
        Me.box09.Controls.Add(Me.textbox_a09)
        Me.box09.Controls.Add(Me.label_m09_unit)
        Me.box09.Controls.Add(Me.textbox_m09)
        Me.box09.Controls.Add(Me.label_y09)
        Me.box09.Controls.Add(Me.label_a09)
        Me.box09.Controls.Add(Me.label_m09)
        Me.box09.Font = New System.Drawing.Font("David", 10.8!)
        Me.box09.Location = New System.Drawing.Point(207, 38)
        Me.box09.Name = "box09"
        Me.box09.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box09.Size = New System.Drawing.Size(364, 136)
        Me.box09.TabIndex = 15
        Me.box09.TabStop = False
        Me.box09.Text = "נתוני החיזוק"
        '
        'label_y09_unit
        '
        Me.label_y09_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y09_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y09_unit.Name = "label_y09_unit"
        Me.label_y09_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_y09_unit.TabIndex = 8
        Me.label_y09_unit.Text = "[cm]"
        '
        'textbox_y09
        '
        Me.textbox_y09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y09.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y09.Name = "textbox_y09"
        Me.textbox_y09.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y09.TabIndex = 7
        '
        'label_a09_unit
        '
        Me.label_a09_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a09_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a09_unit.Name = "label_a09_unit"
        Me.label_a09_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_a09_unit.TabIndex = 6
        Me.label_a09_unit.Text = "[cm^2]"
        '
        'textbox_a09
        '
        Me.textbox_a09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a09.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a09.Name = "textbox_a09"
        Me.textbox_a09.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a09.TabIndex = 5
        '
        'label_m09_unit
        '
        Me.label_m09_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m09_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m09_unit.Name = "label_m09_unit"
        Me.label_m09_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_m09_unit.TabIndex = 4
        Me.label_m09_unit.Text = "[cm^4]"
        '
        'textbox_m09
        '
        Me.textbox_m09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m09.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m09.Name = "textbox_m09"
        Me.textbox_m09.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m09.TabIndex = 3
        '
        'label_y09
        '
        Me.label_y09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y09.Location = New System.Drawing.Point(188, 94)
        Me.label_y09.Name = "label_y09"
        Me.label_y09.Size = New System.Drawing.Size(164, 24)
        Me.label_y09.TabIndex = 2
        Me.label_y09.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a09
        '
        Me.label_a09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a09.Location = New System.Drawing.Point(188, 63)
        Me.label_a09.Name = "label_a09"
        Me.label_a09.Size = New System.Drawing.Size(164, 24)
        Me.label_a09.TabIndex = 1
        Me.label_a09.Text = "שטח חתך החיזוק"
        '
        'label_m09
        '
        Me.label_m09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m09.Location = New System.Drawing.Point(188, 32)
        Me.label_m09.Name = "label_m09"
        Me.label_m09.Size = New System.Drawing.Size(164, 24)
        Me.label_m09.TabIndex = 0
        Me.label_m09.Text = "מומנט אינרציה (Ix)"
        '
        'Label_title09
        '
        Me.Label_title09.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title09.Location = New System.Drawing.Point(16, 24)
        Me.Label_title09.Name = "Label_title09"
        Me.Label_title09.Size = New System.Drawing.Size(188, 20)
        Me.Label_title09.TabIndex = 1
        Me.Label_title09.Text = "שם החיזוק לפי התקן"
        '
        'Equal_Angles
        '
        Me.Equal_Angles.ItemHeight = 16
        Me.Equal_Angles.Items.AddRange(New Object() {"315x100x12x15", "340x120x12x15", "370x120x12x20", "395x120x12x20", "425x120x12x25", "450x120x12x25", "455x120x12x30", "460x120x12x35", "475x120x12x25", "525x120x12x25", "525x150x12x25", "530x150x12x30", "535x150x12x35", "575x150x12x25", "585x150x12x35", "625x150x12x25", "630x150x12x30", "635x150x12x35", "625x200x12x25", "630x200x12x30", "635x200x12x35", "675x200x12x25", "685x200x12x35", "725x200x12x25", "735x200x12x35", "775x200x12x25", "780x200x12x30", "785x200x12x35", "830x200x14x30", "835x200x14x35", "880x200x14x30", "885x200x14x35"})
        Me.Equal_Angles.Location = New System.Drawing.Point(15, 46)
        Me.Equal_Angles.Name = "Equal_Angles"
        Me.Equal_Angles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles.Size = New System.Drawing.Size(189, 276)
        Me.Equal_Angles.TabIndex = 0
        '
        'Equal_Angles_y
        '
        Me.Equal_Angles_y.ItemHeight = 16
        Me.Equal_Angles_y.Items.AddRange(New Object() {"19.6", "21.6", "24.2", "25.6", "28.2", "29.6", "30.7", "31.6", "31", "33.8", "35.1", "36.4", "37.5", "37.9", "40.5", "40.7", "42.1", "43.4", "42.8", "44.3", "45.7", "45.7", "48.7", "48.5", "51.7", "51.3", "53.1", "54.7", "54.5", "56.1", "57.2", "58.9"})
        Me.Equal_Angles_y.Location = New System.Drawing.Point(296, 260)
        Me.Equal_Angles_y.Name = "Equal_Angles_y"
        Me.Equal_Angles_y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_y.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_y.TabIndex = 10
        Me.Equal_Angles_y.Visible = False
        '
        'Equal_Angles_area
        '
        Me.Equal_Angles_area.ItemHeight = 16
        Me.Equal_Angles_area.Items.AddRange(New Object() {"51", "57", "66", "69", "78", "81", "87", "93", "84", "90", "97.5", "105", "112.5", "103.5", "118.5", "109.5", "117", "124.5", "122", "132", "142", "128", "148", "134", "154", "140", "150", "160", "172", "182", "179", "189"})
        Me.Equal_Angles_area.Location = New System.Drawing.Point(296, 220)
        Me.Equal_Angles_area.Name = "Equal_Angles_area"
        Me.Equal_Angles_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_area.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_area.TabIndex = 9
        Me.Equal_Angles_area.Visible = False
        '
        'Equal_Angles_I
        '
        Me.Equal_Angles_I.ItemHeight = 16
        Me.Equal_Angles_I.Items.AddRange(New Object() {"5329", "6995", "9523", "11387", "14750", "17250", "18630", "19900", "20010", "26300", "28420", "30590", "32590", "36420", "41710", "45700", "49110", "52260", "50440", "54120", "57450", "62190", "70810", "75510", "85940", "90480", "96990", "102920", "127070", "134890", "148920", "158020"})
        Me.Equal_Angles_I.Location = New System.Drawing.Point(296, 176)
        Me.Equal_Angles_I.Name = "Equal_Angles_I"
        Me.Equal_Angles_I.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_I.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_I.TabIndex = 8
        Me.Equal_Angles_I.Visible = False
        '
        'Equal_Angles_flange_thickness
        '
        Me.Equal_Angles_flange_thickness.ItemHeight = 16
        Me.Equal_Angles_flange_thickness.Items.AddRange(New Object() {"15", "15", "20", "20", "25", "25", "30", "35", "25", "25", "25", "30", "35", "25", "35", "25", "30", "35", "25", "30", "35", "25", "35", "25", "35", "25", "30", "35", "30", "35", "30", "35"})
        Me.Equal_Angles_flange_thickness.Location = New System.Drawing.Point(224, 292)
        Me.Equal_Angles_flange_thickness.Name = "Equal_Angles_flange_thickness"
        Me.Equal_Angles_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_flange_thickness.TabIndex = 7
        Me.Equal_Angles_flange_thickness.Visible = False
        '
        'Equal_Angles_flange_breadth
        '
        Me.Equal_Angles_flange_breadth.ItemHeight = 16
        Me.Equal_Angles_flange_breadth.Items.AddRange(New Object() {"100", "120", "120", "120", "120", "120", "120", "120", "120", "120", "150", "150", "150", "150", "150", "150", "150", "150", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200"})
        Me.Equal_Angles_flange_breadth.Location = New System.Drawing.Point(228, 264)
        Me.Equal_Angles_flange_breadth.Name = "Equal_Angles_flange_breadth"
        Me.Equal_Angles_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_flange_breadth.TabIndex = 6
        Me.Equal_Angles_flange_breadth.Visible = False
        '
        'Equal_Angles_web_thickness
        '
        Me.Equal_Angles_web_thickness.ItemHeight = 16
        Me.Equal_Angles_web_thickness.Items.AddRange(New Object() {"12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "14", "14", "14", "14"})
        Me.Equal_Angles_web_thickness.Location = New System.Drawing.Point(228, 220)
        Me.Equal_Angles_web_thickness.Name = "Equal_Angles_web_thickness"
        Me.Equal_Angles_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_web_thickness.TabIndex = 5
        Me.Equal_Angles_web_thickness.Visible = False
        '
        'Equal_Angles_web_depth
        '
        Me.Equal_Angles_web_depth.ItemHeight = 16
        Me.Equal_Angles_web_depth.Items.AddRange(New Object() {"300", "325", "350", "375", "400", "425", "425", "425", "450", "500", "500", "500", "500", "550", "550", "600", "600", "600", "600", "600", "600", "650", "650", "700", "700", "750", "750", "750", "800", "800", "850", "850"})
        Me.Equal_Angles_web_depth.Location = New System.Drawing.Point(228, 180)
        Me.Equal_Angles_web_depth.Name = "Equal_Angles_web_depth"
        Me.Equal_Angles_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.Equal_Angles_web_depth.TabIndex = 3
        Me.Equal_Angles_web_depth.Visible = False
        '
        'IP_pic
        '
        Me.IP_pic.Controls.Add(Me.Equal_Angles_flange_breadth_label)
        Me.IP_pic.Controls.Add(Me.Equal_Angles_flange_thickness_label)
        Me.IP_pic.Controls.Add(Me.Equal_Angles_web_thickness_label)
        Me.IP_pic.Controls.Add(Me.Equal_Angles_web_depth_label)
        Me.IP_pic.Controls.Add(Me.PictureBox5)
        Me.IP_pic.Location = New System.Drawing.Point(580, 40)
        Me.IP_pic.Name = "IP_pic"
        Me.IP_pic.Size = New System.Drawing.Size(276, 280)
        Me.IP_pic.TabIndex = 22
        Me.IP_pic.TabStop = False
        Me.IP_pic.Text = "Profile: Inexa Profil (Equal Angles)"
        '
        'Equal_Angles_flange_breadth_label
        '
        Me.Equal_Angles_flange_breadth_label.AutoEllipsis = True
        Me.Equal_Angles_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.Equal_Angles_flange_breadth_label.Location = New System.Drawing.Point(136, 16)
        Me.Equal_Angles_flange_breadth_label.Name = "Equal_Angles_flange_breadth_label"
        Me.Equal_Angles_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_flange_breadth_label.Size = New System.Drawing.Size(76, 20)
        Me.Equal_Angles_flange_breadth_label.TabIndex = 14
        '
        'Equal_Angles_flange_thickness_label
        '
        Me.Equal_Angles_flange_thickness_label.AutoEllipsis = True
        Me.Equal_Angles_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.Equal_Angles_flange_thickness_label.Location = New System.Drawing.Point(20, 56)
        Me.Equal_Angles_flange_thickness_label.Name = "Equal_Angles_flange_thickness_label"
        Me.Equal_Angles_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_flange_thickness_label.Size = New System.Drawing.Size(65, 20)
        Me.Equal_Angles_flange_thickness_label.TabIndex = 13
        '
        'Equal_Angles_web_thickness_label
        '
        Me.Equal_Angles_web_thickness_label.AutoEllipsis = True
        Me.Equal_Angles_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.Equal_Angles_web_thickness_label.Location = New System.Drawing.Point(80, 232)
        Me.Equal_Angles_web_thickness_label.Name = "Equal_Angles_web_thickness_label"
        Me.Equal_Angles_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_web_thickness_label.Size = New System.Drawing.Size(72, 20)
        Me.Equal_Angles_web_thickness_label.TabIndex = 12
        '
        'Equal_Angles_web_depth_label
        '
        Me.Equal_Angles_web_depth_label.AutoEllipsis = True
        Me.Equal_Angles_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.Equal_Angles_web_depth_label.Location = New System.Drawing.Point(20, 128)
        Me.Equal_Angles_web_depth_label.Name = "Equal_Angles_web_depth_label"
        Me.Equal_Angles_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Equal_Angles_web_depth_label.Size = New System.Drawing.Size(67, 21)
        Me.Equal_Angles_web_depth_label.TabIndex = 11
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(88, 40)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(169, 189)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'NJA_names
        '
        Me.NJA_names.ItemHeight = 16
        Me.NJA_names.Items.AddRange(New Object() {"200x90x9x12", "250x90x9x13", "250x90x10.5x15", "250x90x11.5x16", "300x100x10.5x15", "300x100x11.5x16", "325x120x10.5x14", "325x120x11.5x15", "350x120x10.5x16", "350x120x11.5x18", "375x120x10.5x18", "375x120x11.5x20", "400x120x11.5x23"})
        Me.NJA_names.Location = New System.Drawing.Point(15, 46)
        Me.NJA_names.Name = "NJA_names"
        Me.NJA_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NJA_names.Size = New System.Drawing.Size(189, 276)
        Me.NJA_names.TabIndex = 23
        '
        'IP_Jumbo_bulb
        '
        Me.IP_Jumbo_bulb.Controls.Add(Me.box10)
        Me.IP_Jumbo_bulb.Controls.Add(Me.Label_title10)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_Y)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_A)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_i)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_bulb_radius)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_flange_breadth)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_web_thickness)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_web_depth)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_Bulb_names)
        Me.IP_Jumbo_bulb.Controls.Add(Me.IP_Jumbo_bulb_groupbox)
        Me.IP_Jumbo_bulb.Location = New System.Drawing.Point(6, 12)
        Me.IP_Jumbo_bulb.Name = "IP_Jumbo_bulb"
        Me.IP_Jumbo_bulb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_bulb.Size = New System.Drawing.Size(868, 356)
        Me.IP_Jumbo_bulb.TabIndex = 9
        Me.IP_Jumbo_bulb.TabStop = False
        Me.IP_Jumbo_bulb.Text = "Inexa Profil - Jumbo Bulb Flats"
        Me.IP_Jumbo_bulb.Visible = False
        '
        'box10
        '
        Me.box10.Controls.Add(Me.label_y10_unit)
        Me.box10.Controls.Add(Me.textbox_y10)
        Me.box10.Controls.Add(Me.label_a10_unit)
        Me.box10.Controls.Add(Me.textbox_a10)
        Me.box10.Controls.Add(Me.label_m10_unit)
        Me.box10.Controls.Add(Me.textbox_m10)
        Me.box10.Controls.Add(Me.label_y10)
        Me.box10.Controls.Add(Me.label_a10)
        Me.box10.Controls.Add(Me.label_m10)
        Me.box10.Font = New System.Drawing.Font("David", 10.8!)
        Me.box10.Location = New System.Drawing.Point(207, 38)
        Me.box10.Name = "box10"
        Me.box10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box10.Size = New System.Drawing.Size(364, 136)
        Me.box10.TabIndex = 15
        Me.box10.TabStop = False
        Me.box10.Text = "נתוני החיזוק"
        '
        'label_y10_unit
        '
        Me.label_y10_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y10_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y10_unit.Name = "label_y10_unit"
        Me.label_y10_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_y10_unit.TabIndex = 8
        Me.label_y10_unit.Text = "[cm]"
        '
        'textbox_y10
        '
        Me.textbox_y10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y10.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y10.Name = "textbox_y10"
        Me.textbox_y10.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y10.TabIndex = 7
        '
        'label_a10_unit
        '
        Me.label_a10_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a10_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a10_unit.Name = "label_a10_unit"
        Me.label_a10_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_a10_unit.TabIndex = 6
        Me.label_a10_unit.Text = "[cm^2]"
        '
        'textbox_a10
        '
        Me.textbox_a10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a10.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a10.Name = "textbox_a10"
        Me.textbox_a10.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a10.TabIndex = 5
        '
        'label_m10_unit
        '
        Me.label_m10_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m10_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m10_unit.Name = "label_m10_unit"
        Me.label_m10_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_m10_unit.TabIndex = 4
        Me.label_m10_unit.Text = "[cm^4]"
        '
        'textbox_m10
        '
        Me.textbox_m10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m10.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m10.Name = "textbox_m10"
        Me.textbox_m10.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m10.TabIndex = 3
        '
        'label_y10
        '
        Me.label_y10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y10.Location = New System.Drawing.Point(188, 94)
        Me.label_y10.Name = "label_y10"
        Me.label_y10.Size = New System.Drawing.Size(164, 24)
        Me.label_y10.TabIndex = 2
        Me.label_y10.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a10
        '
        Me.label_a10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a10.Location = New System.Drawing.Point(188, 63)
        Me.label_a10.Name = "label_a10"
        Me.label_a10.Size = New System.Drawing.Size(164, 24)
        Me.label_a10.TabIndex = 1
        Me.label_a10.Text = "שטח חתך החיזוק"
        '
        'label_m10
        '
        Me.label_m10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m10.Location = New System.Drawing.Point(188, 32)
        Me.label_m10.Name = "label_m10"
        Me.label_m10.Size = New System.Drawing.Size(164, 24)
        Me.label_m10.TabIndex = 0
        Me.label_m10.Text = "מומנט אינרציה (Ix)"
        '
        'Label_title10
        '
        Me.Label_title10.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title10.Location = New System.Drawing.Point(15, 22)
        Me.Label_title10.Name = "Label_title10"
        Me.Label_title10.Size = New System.Drawing.Size(189, 20)
        Me.Label_title10.TabIndex = 1
        Me.Label_title10.Text = "שם החיזוק לפי התקן"
        '
        'IP_Jumbo_Bulb_Y
        '
        Me.IP_Jumbo_Bulb_Y.ItemHeight = 16
        Me.IP_Jumbo_Bulb_Y.Items.AddRange(New Object() {"28.4", "27.6", "31.5", "30.6", "34.5", "33.5", "37.5", "36.4", "40.4", "39.3", "43.3", "42.1"})
        Me.IP_Jumbo_Bulb_Y.Location = New System.Drawing.Point(312, 288)
        Me.IP_Jumbo_Bulb_Y.Name = "IP_Jumbo_Bulb_Y"
        Me.IP_Jumbo_Bulb_Y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_Y.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_Y.TabIndex = 10
        Me.IP_Jumbo_Bulb_Y.Visible = False
        '
        'IP_Jumbo_Bulb_A
        '
        Me.IP_Jumbo_Bulb_A.ItemHeight = 16
        Me.IP_Jumbo_Bulb_A.Items.AddRange(New Object() {"92.1", "98.7", "98.1", "105.7", "104.1", "112.7", "110.1", "119.7", "116.1", "126.7", "122.1", "133.7"})
        Me.IP_Jumbo_Bulb_A.Location = New System.Drawing.Point(312, 248)
        Me.IP_Jumbo_Bulb_A.Name = "IP_Jumbo_Bulb_A"
        Me.IP_Jumbo_Bulb_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_A.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_A.TabIndex = 9
        Me.IP_Jumbo_Bulb_A.Visible = False
        '
        'IP_Jumbo_Bulb_i
        '
        Me.IP_Jumbo_Bulb_i.ItemHeight = 16
        Me.IP_Jumbo_Bulb_i.Items.AddRange(New Object() {"13530", "14990", "18900", "20920", "25440", "28110", "33220", "36670", "42340", "46700", "52870", "58290"})
        Me.IP_Jumbo_Bulb_i.Location = New System.Drawing.Point(312, 207)
        Me.IP_Jumbo_Bulb_i.Name = "IP_Jumbo_Bulb_i"
        Me.IP_Jumbo_Bulb_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_i.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_i.TabIndex = 8
        Me.IP_Jumbo_Bulb_i.Visible = False
        '
        'IP_Jumbo_Bulb_bulb_radius
        '
        Me.IP_Jumbo_Bulb_bulb_radius.ItemHeight = 16
        Me.IP_Jumbo_Bulb_bulb_radius.Items.AddRange(New Object() {"5", "5", "5", "5", "5", "5", "5", "5", "5", "5", "5", "5"})
        Me.IP_Jumbo_Bulb_bulb_radius.Location = New System.Drawing.Point(244, 336)
        Me.IP_Jumbo_Bulb_bulb_radius.Name = "IP_Jumbo_Bulb_bulb_radius"
        Me.IP_Jumbo_Bulb_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_bulb_radius.TabIndex = 7
        Me.IP_Jumbo_Bulb_bulb_radius.Visible = False
        '
        'IP_Jumbo_Bulb_flange_breadth
        '
        Me.IP_Jumbo_Bulb_flange_breadth.ItemHeight = 16
        Me.IP_Jumbo_Bulb_flange_breadth.Items.AddRange(New Object() {"98", "96", "98", "96", "98", "96", "98", "96", "98", "96", "98", "96"})
        Me.IP_Jumbo_Bulb_flange_breadth.Location = New System.Drawing.Point(244, 292)
        Me.IP_Jumbo_Bulb_flange_breadth.Name = "IP_Jumbo_Bulb_flange_breadth"
        Me.IP_Jumbo_Bulb_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_flange_breadth.TabIndex = 6
        Me.IP_Jumbo_Bulb_flange_breadth.Visible = False
        '
        'IP_Jumbo_Bulb_web_thickness
        '
        Me.IP_Jumbo_Bulb_web_thickness.ItemHeight = 16
        Me.IP_Jumbo_Bulb_web_thickness.Items.AddRange(New Object() {"12", "14", "12", "14", "12", "14", "12", "14", "12", "14", "12", "14"})
        Me.IP_Jumbo_Bulb_web_thickness.Location = New System.Drawing.Point(244, 248)
        Me.IP_Jumbo_Bulb_web_thickness.Name = "IP_Jumbo_Bulb_web_thickness"
        Me.IP_Jumbo_Bulb_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_web_thickness.TabIndex = 5
        Me.IP_Jumbo_Bulb_web_thickness.Visible = False
        '
        'IP_Jumbo_Bulb_web_depth
        '
        Me.IP_Jumbo_Bulb_web_depth.ItemHeight = 16
        Me.IP_Jumbo_Bulb_web_depth.Items.AddRange(New Object() {"400", "400", "450", "450", "500", "500", "550", "550", "600", "600", "650", "650"})
        Me.IP_Jumbo_Bulb_web_depth.Location = New System.Drawing.Point(244, 208)
        Me.IP_Jumbo_Bulb_web_depth.Name = "IP_Jumbo_Bulb_web_depth"
        Me.IP_Jumbo_Bulb_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_web_depth.TabIndex = 3
        Me.IP_Jumbo_Bulb_web_depth.Visible = False
        '
        'IP_Jumbo_Bulb_names
        '
        Me.IP_Jumbo_Bulb_names.ItemHeight = 16
        Me.IP_Jumbo_Bulb_names.Items.AddRange(New Object() {"400x110x12", "400x110x14", "450x110x12", "450x110x14", "500x110x12", "500x110x14", "550x110x12", "550x110x14", "600x110x12", "600x110x14", "650x110x12", "650x110x14"})
        Me.IP_Jumbo_Bulb_names.Location = New System.Drawing.Point(15, 46)
        Me.IP_Jumbo_Bulb_names.Name = "IP_Jumbo_Bulb_names"
        Me.IP_Jumbo_Bulb_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_names.Size = New System.Drawing.Size(189, 276)
        Me.IP_Jumbo_Bulb_names.TabIndex = 0
        '
        'IP_Jumbo_bulb_groupbox
        '
        Me.IP_Jumbo_bulb_groupbox.Controls.Add(Me.IP_Jumbo_Bulb_web_thickness_label)
        Me.IP_Jumbo_bulb_groupbox.Controls.Add(Me.IP_Jumbo_Bulb_bulb_radius_label)
        Me.IP_Jumbo_bulb_groupbox.Controls.Add(Me.IP_Jumbo_Bulb_flange_breadth_label)
        Me.IP_Jumbo_bulb_groupbox.Controls.Add(Me.IP_Jumbo_Bulb_web_depth_label)
        Me.IP_Jumbo_bulb_groupbox.Controls.Add(Me.PictureBox6)
        Me.IP_Jumbo_bulb_groupbox.Location = New System.Drawing.Point(580, 40)
        Me.IP_Jumbo_bulb_groupbox.Name = "IP_Jumbo_bulb_groupbox"
        Me.IP_Jumbo_bulb_groupbox.Size = New System.Drawing.Size(276, 280)
        Me.IP_Jumbo_bulb_groupbox.TabIndex = 22
        Me.IP_Jumbo_bulb_groupbox.TabStop = False
        Me.IP_Jumbo_bulb_groupbox.Text = "Profile: Inexa Profil (Jumbo Bulbs)"
        '
        'IP_Jumbo_Bulb_web_thickness_label
        '
        Me.IP_Jumbo_Bulb_web_thickness_label.AutoEllipsis = True
        Me.IP_Jumbo_Bulb_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_Jumbo_Bulb_web_thickness_label.Location = New System.Drawing.Point(104, 244)
        Me.IP_Jumbo_Bulb_web_thickness_label.Name = "IP_Jumbo_Bulb_web_thickness_label"
        Me.IP_Jumbo_Bulb_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_web_thickness_label.Size = New System.Drawing.Size(72, 19)
        Me.IP_Jumbo_Bulb_web_thickness_label.TabIndex = 12
        '
        'IP_Jumbo_Bulb_bulb_radius_label
        '
        Me.IP_Jumbo_Bulb_bulb_radius_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_Jumbo_Bulb_bulb_radius_label.Location = New System.Drawing.Point(216, 54)
        Me.IP_Jumbo_Bulb_bulb_radius_label.Name = "IP_Jumbo_Bulb_bulb_radius_label"
        Me.IP_Jumbo_Bulb_bulb_radius_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_bulb_radius_label.Size = New System.Drawing.Size(77, 20)
        Me.IP_Jumbo_Bulb_bulb_radius_label.TabIndex = 14
        '
        'IP_Jumbo_Bulb_flange_breadth_label
        '
        Me.IP_Jumbo_Bulb_flange_breadth_label.AutoEllipsis = True
        Me.IP_Jumbo_Bulb_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_Jumbo_Bulb_flange_breadth_label.Location = New System.Drawing.Point(134, 22)
        Me.IP_Jumbo_Bulb_flange_breadth_label.Name = "IP_Jumbo_Bulb_flange_breadth_label"
        Me.IP_Jumbo_Bulb_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_flange_breadth_label.Size = New System.Drawing.Size(64, 20)
        Me.IP_Jumbo_Bulb_flange_breadth_label.TabIndex = 13
        '
        'IP_Jumbo_Bulb_web_depth_label
        '
        Me.IP_Jumbo_Bulb_web_depth_label.AutoEllipsis = True
        Me.IP_Jumbo_Bulb_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_Jumbo_Bulb_web_depth_label.Location = New System.Drawing.Point(40, 136)
        Me.IP_Jumbo_Bulb_web_depth_label.Name = "IP_Jumbo_Bulb_web_depth_label"
        Me.IP_Jumbo_Bulb_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Jumbo_Bulb_web_depth_label.Size = New System.Drawing.Size(67, 21)
        Me.IP_Jumbo_Bulb_web_depth_label.TabIndex = 11
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(112, 44)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(96, 196)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'IP_Rolled_Bulb_Flats
        '
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.Label_title11)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_centroid)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_a)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_i)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_bulb_radius)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_flange_breadth)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_web_thickness)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_web_depth)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_rolled_names)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.box11)
        Me.IP_Rolled_Bulb_Flats.Controls.Add(Me.IP_Rolled_Bulb_Flats_pic)
        Me.IP_Rolled_Bulb_Flats.Location = New System.Drawing.Point(6, 12)
        Me.IP_Rolled_Bulb_Flats.Name = "IP_Rolled_Bulb_Flats"
        Me.IP_Rolled_Bulb_Flats.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Rolled_Bulb_Flats.Size = New System.Drawing.Size(868, 356)
        Me.IP_Rolled_Bulb_Flats.TabIndex = 10
        Me.IP_Rolled_Bulb_Flats.TabStop = False
        Me.IP_Rolled_Bulb_Flats.Text = "Inexa Profil - Rolled Bulb Flats"
        Me.IP_Rolled_Bulb_Flats.Visible = False
        '
        'Label_title11
        '
        Me.Label_title11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title11.Location = New System.Drawing.Point(12, 23)
        Me.Label_title11.Name = "Label_title11"
        Me.Label_title11.Size = New System.Drawing.Size(196, 20)
        Me.Label_title11.TabIndex = 1
        Me.Label_title11.Text = "שם החיזוק לפי התקן"
        '
        'IP_rolled_centroid
        '
        Me.IP_rolled_centroid.ItemHeight = 16
        Me.IP_rolled_centroid.Items.AddRange(New Object() {"3.82", "3.7", "3.62", "4.89", "4.78", "4.69", "5.98", "5.87", "5.78", "7.2", "7.07", "6.96", "8.31", "8.18", "8.07", "9.66", "9.49", "9.36", "10.9", "10.7", "10.6", "12.1", "11.9", "11.7", "13.4", "13.1", "14.7", "14.6", "14.4", "16.2", "16", "15.8", "17.4", "17.2", "18.9", "18.7", "18.5", "20.1", "19.9", "21.5", "21.1", "23.5", "23", "25.5", "25", "27.4", "26.9"})
        Me.IP_rolled_centroid.Location = New System.Drawing.Point(236, 293)
        Me.IP_rolled_centroid.Name = "IP_rolled_centroid"
        Me.IP_rolled_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_centroid.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_centroid.TabIndex = 10
        Me.IP_rolled_centroid.Visible = False
        '
        'IP_rolled_a
        '
        Me.IP_rolled_a.ItemHeight = 16
        Me.IP_rolled_a.Items.AddRange(New Object() {"3.58", "4.18", "4.78", "5.4", "6.2", "7", "7.74", "8.74", "9.74", "9.31", "10.5", "11.7", "12.4", "13.8", "15.2", "14.6", "16.2", "17.8", "18.9", "20.7", "22.5", "23.6", "25.6", "28.6", "29", "32.3", "32.4", "34.9", "37.3", "36.1", "38.7", "41.3", "42.6", "45.5", "46.7", "49.7", "52.8", "54.2", "57.4", "58.8", "65.5", "69.6", "77", "81.4", "89.4", "94.1", "103"})
        Me.IP_rolled_a.Location = New System.Drawing.Point(236, 253)
        Me.IP_rolled_a.Name = "IP_rolled_a"
        Me.IP_rolled_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_a.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_a.TabIndex = 9
        Me.IP_rolled_a.Visible = False
        '
        'IP_rolled_i
        '
        Me.IP_rolled_i.ItemHeight = 16
        Me.IP_rolled_i.Items.AddRange(New Object() {"12.2", "14.4", "16.4", "33.8", "39", "43.3", "76.1", "85.3", "94.3", "133", "148", "164", "241", "266", "291", "373", "411", "448", "609", "663", "717", "941", "1020", "1126", "1400", "1550", "1860", "2000", "2130", "2430", "2610", "2770", "3330", "3550", "4190", "4460", "4720", "5530", "5850", "6760", "7540", "9470", "10490", "12930", "14220", "17260", "18860"})
        Me.IP_rolled_i.Location = New System.Drawing.Point(236, 209)
        Me.IP_rolled_i.Name = "IP_rolled_i"
        Me.IP_rolled_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_i.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_i.TabIndex = 8
        Me.IP_rolled_i.Visible = False
        '
        'IP_rolled_bulb_radius
        '
        Me.IP_rolled_bulb_radius.ItemHeight = 16
        Me.IP_rolled_bulb_radius.Items.AddRange(New Object() {"3.5", "3.5", "3.5", "4", "4", "4", "4.5", "4.5", "4.5", "5", "5", "5", "5.5", "5.5", "5.5", "6", "6", "6", "7", "7", "7", "8", "8", "8", "9", "9", "10", "10", "10", "11", "11", "11", "12", "12", "13", "13", "13", "14", "14", "15", "15", "16.5", "16.5", "18", "18", "19.5", "19.5"})
        Me.IP_rolled_bulb_radius.Location = New System.Drawing.Point(168, 336)
        Me.IP_rolled_bulb_radius.Name = "IP_rolled_bulb_radius"
        Me.IP_rolled_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_bulb_radius.TabIndex = 7
        Me.IP_rolled_bulb_radius.Visible = False
        '
        'IP_rolled_flange_breadth
        '
        Me.IP_rolled_flange_breadth.ItemHeight = 16
        Me.IP_rolled_flange_breadth.Items.AddRange(New Object() {"13", "13", "13", "14", "14", "14", "15.5", "15.5", "15.5", "17", "17", "17", "19", "19", "19", "22", "22", "22", "25", "25", "25", "28", "28", "28", "31", "31", "34", "34", "34", "37", "37", "37", "40", "40", "43", "43", "43", "46", "46", "49", "49", "53.5", "53.5", "58", "58", "62.5", "62.5"})
        Me.IP_rolled_flange_breadth.Location = New System.Drawing.Point(168, 292)
        Me.IP_rolled_flange_breadth.Name = "IP_rolled_flange_breadth"
        Me.IP_rolled_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_flange_breadth.TabIndex = 6
        Me.IP_rolled_flange_breadth.Visible = False
        '
        'IP_rolled_web_thickness
        '
        Me.IP_rolled_web_thickness.ItemHeight = 16
        Me.IP_rolled_web_thickness.Items.AddRange(New Object() {"4", "5", "6", "5", "6", "7", "6", "7", "8", "6", "7", "8", "7", "8", "9", "7", "8", "9", "8", "9", "10", "9", "10", "11.5", "10", "11.5", "10", "11", "12", "10", "11", "12", "11", "12", "11", "12", "13", "12", "13", "12", "14", "13", "15", "14", "16", "15", "17"})
        Me.IP_rolled_web_thickness.Location = New System.Drawing.Point(168, 248)
        Me.IP_rolled_web_thickness.Name = "IP_rolled_web_thickness"
        Me.IP_rolled_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_web_thickness.TabIndex = 5
        Me.IP_rolled_web_thickness.Visible = False
        '
        'IP_rolled_web_depth
        '
        Me.IP_rolled_web_depth.ItemHeight = 16
        Me.IP_rolled_web_depth.Items.AddRange(New Object() {"60", "60", "60", "80", "80", "80", "100", "100", "100", "120", "120", "120", "140", "140", "140", "160", "160", "160", "180", "180", "180", "200", "200", "200", "220", "220", "240", "240", "240", "260", "260", "260", "280", "280", "300", "300", "300", "320", "320", "340", "340", "370", "370", "400", "400", "430", "430"})
        Me.IP_rolled_web_depth.Location = New System.Drawing.Point(168, 208)
        Me.IP_rolled_web_depth.Name = "IP_rolled_web_depth"
        Me.IP_rolled_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.IP_rolled_web_depth.TabIndex = 3
        Me.IP_rolled_web_depth.Visible = False
        '
        'IP_rolled_names
        '
        Me.IP_rolled_names.ItemHeight = 16
        Me.IP_rolled_names.Items.AddRange(New Object() {"60x4", "60x5", "60x6", "80x5", "80x6", "80x7", "100x6", "100x7", "100x8", "120x6", "120x7", "120x8", "140x7", "140x8", "140x9", "160x7", "160x8", "160x9", "180x8", "180x9", "180x10", "200x9", "200x10", "200x11.5", "220x10", "220x11.5", "240x10", "240x11", "240x12", "260x10", "260x11", "260x12", "280x11", "280x12", "300x11", "300x12", "300x13", "320x12", "320x13", "340x12", "340x14", "370x13", "370x15", "400x14", "400x16", "430x15", "430x17"})
        Me.IP_rolled_names.Location = New System.Drawing.Point(15, 46)
        Me.IP_rolled_names.Name = "IP_rolled_names"
        Me.IP_rolled_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_names.Size = New System.Drawing.Size(189, 276)
        Me.IP_rolled_names.TabIndex = 0
        '
        'IP_Rolled_Bulb_Flats_pic
        '
        Me.IP_Rolled_Bulb_Flats_pic.Controls.Add(Me.IP_rolled_bulb_radius_label)
        Me.IP_Rolled_Bulb_Flats_pic.Controls.Add(Me.IP_rolled_flange_breadth_label)
        Me.IP_Rolled_Bulb_Flats_pic.Controls.Add(Me.IP_rolled_web_thickness_label)
        Me.IP_Rolled_Bulb_Flats_pic.Controls.Add(Me.IP_rolled_web_depth_label)
        Me.IP_Rolled_Bulb_Flats_pic.Controls.Add(Me.PictureBox7)
        Me.IP_Rolled_Bulb_Flats_pic.Location = New System.Drawing.Point(580, 40)
        Me.IP_Rolled_Bulb_Flats_pic.Name = "IP_Rolled_Bulb_Flats_pic"
        Me.IP_Rolled_Bulb_Flats_pic.Size = New System.Drawing.Size(276, 280)
        Me.IP_Rolled_Bulb_Flats_pic.TabIndex = 22
        Me.IP_Rolled_Bulb_Flats_pic.TabStop = False
        Me.IP_Rolled_Bulb_Flats_pic.Text = "Profile: Inexa Profil - Rolled Bulb Flats"
        '
        'IP_rolled_bulb_radius_label
        '
        Me.IP_rolled_bulb_radius_label.AutoEllipsis = True
        Me.IP_rolled_bulb_radius_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_rolled_bulb_radius_label.Location = New System.Drawing.Point(192, 64)
        Me.IP_rolled_bulb_radius_label.Name = "IP_rolled_bulb_radius_label"
        Me.IP_rolled_bulb_radius_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_bulb_radius_label.Size = New System.Drawing.Size(75, 20)
        Me.IP_rolled_bulb_radius_label.TabIndex = 14
        '
        'IP_rolled_flange_breadth_label
        '
        Me.IP_rolled_flange_breadth_label.AutoEllipsis = True
        Me.IP_rolled_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_rolled_flange_breadth_label.Location = New System.Drawing.Point(120, 32)
        Me.IP_rolled_flange_breadth_label.Name = "IP_rolled_flange_breadth_label"
        Me.IP_rolled_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_flange_breadth_label.Size = New System.Drawing.Size(64, 19)
        Me.IP_rolled_flange_breadth_label.TabIndex = 13
        '
        'IP_rolled_web_thickness_label
        '
        Me.IP_rolled_web_thickness_label.AutoEllipsis = True
        Me.IP_rolled_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_rolled_web_thickness_label.Location = New System.Drawing.Point(104, 240)
        Me.IP_rolled_web_thickness_label.Name = "IP_rolled_web_thickness_label"
        Me.IP_rolled_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_web_thickness_label.Size = New System.Drawing.Size(72, 19)
        Me.IP_rolled_web_thickness_label.TabIndex = 12
        '
        'IP_rolled_web_depth_label
        '
        Me.IP_rolled_web_depth_label.AutoEllipsis = True
        Me.IP_rolled_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.IP_rolled_web_depth_label.Location = New System.Drawing.Point(32, 136)
        Me.IP_rolled_web_depth_label.Name = "IP_rolled_web_depth_label"
        Me.IP_rolled_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_rolled_web_depth_label.Size = New System.Drawing.Size(76, 20)
        Me.IP_rolled_web_depth_label.TabIndex = 11
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(112, 52)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(72, 184)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'box11
        '
        Me.box11.Controls.Add(Me.label_y11_unit)
        Me.box11.Controls.Add(Me.textbox_y11)
        Me.box11.Controls.Add(Me.label_a11_unit)
        Me.box11.Controls.Add(Me.textbox_a11)
        Me.box11.Controls.Add(Me.label_m11_unit)
        Me.box11.Controls.Add(Me.textbox_m11)
        Me.box11.Controls.Add(Me.label_y11)
        Me.box11.Controls.Add(Me.label_a11)
        Me.box11.Controls.Add(Me.label_m11)
        Me.box11.Font = New System.Drawing.Font("David", 10.8!)
        Me.box11.Location = New System.Drawing.Point(207, 38)
        Me.box11.Name = "box11"
        Me.box11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box11.Size = New System.Drawing.Size(364, 136)
        Me.box11.TabIndex = 15
        Me.box11.TabStop = False
        Me.box11.Text = "נתוני החיזוק"
        '
        'label_y11_unit
        '
        Me.label_y11_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y11_unit.Location = New System.Drawing.Point(12, 94)
        Me.label_y11_unit.Name = "label_y11_unit"
        Me.label_y11_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_y11_unit.TabIndex = 8
        Me.label_y11_unit.Text = "[cm]"
        '
        'textbox_y11
        '
        Me.textbox_y11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y11.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y11.Name = "textbox_y11"
        Me.textbox_y11.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y11.TabIndex = 7
        '
        'label_a11_unit
        '
        Me.label_a11_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a11_unit.Location = New System.Drawing.Point(12, 63)
        Me.label_a11_unit.Name = "label_a11_unit"
        Me.label_a11_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_a11_unit.TabIndex = 6
        Me.label_a11_unit.Text = "[cm^2]"
        '
        'textbox_a11
        '
        Me.textbox_a11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a11.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a11.Name = "textbox_a11"
        Me.textbox_a11.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a11.TabIndex = 5
        '
        'label_m11_unit
        '
        Me.label_m11_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m11_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m11_unit.Name = "label_m11_unit"
        Me.label_m11_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_m11_unit.TabIndex = 4
        Me.label_m11_unit.Text = "[cm^4]"
        '
        'textbox_m11
        '
        Me.textbox_m11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m11.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m11.Name = "textbox_m11"
        Me.textbox_m11.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m11.TabIndex = 3
        '
        'label_y11
        '
        Me.label_y11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y11.Location = New System.Drawing.Point(188, 94)
        Me.label_y11.Name = "label_y11"
        Me.label_y11.Size = New System.Drawing.Size(164, 25)
        Me.label_y11.TabIndex = 2
        Me.label_y11.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a11
        '
        Me.label_a11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a11.Location = New System.Drawing.Point(188, 63)
        Me.label_a11.Name = "label_a11"
        Me.label_a11.Size = New System.Drawing.Size(164, 24)
        Me.label_a11.TabIndex = 1
        Me.label_a11.Text = "שטח חתך החיזוק"
        '
        'label_m11
        '
        Me.label_m11.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m11.Location = New System.Drawing.Point(188, 32)
        Me.label_m11.Name = "label_m11"
        Me.label_m11.Size = New System.Drawing.Size(164, 24)
        Me.label_m11.TabIndex = 0
        Me.label_m11.Text = "מומנט אינרציה (Ix)"
        '
        'FDA_bulb01
        '
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_y)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_a)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_i)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_flange_breadth)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_web_thickness)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_bulb_radius)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_profile_depth)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_y)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_a)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_i)
        Me.FDA_bulb01.Controls.Add(Me.box12)
        Me.FDA_bulb01.Controls.Add(Me.Label_title12)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_names)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_flange_breadth)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_web_thickness)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_bulb_radius)
        Me.FDA_bulb01.Controls.Add(Me.DIN_HBP_profile_depth)
        Me.FDA_bulb01.Controls.Add(Me.ISO_HBP_names)
        Me.FDA_bulb01.Controls.Add(Me.bulb_pic01)
        Me.FDA_bulb01.Location = New System.Drawing.Point(6, 12)
        Me.FDA_bulb01.Name = "FDA_bulb01"
        Me.FDA_bulb01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_bulb01.Size = New System.Drawing.Size(868, 356)
        Me.FDA_bulb01.TabIndex = 11
        Me.FDA_bulb01.TabStop = False
        Me.FDA_bulb01.Text = "DIN Bulbs"
        Me.FDA_bulb01.Visible = False
        '
        'ISO_HBP_y
        '
        Me.ISO_HBP_y.ItemHeight = 16
        Me.ISO_HBP_y.Items.AddRange(New Object() {"4.781651", "4.692508", "5.873469", "5.783885", "7.068597", "6.959197", "8.315387", "8.182188", "9.662187", "9.498041", "9.363401", "10.891839", "10.727008", "10.588598", "12.120983", "11.955663", "11.750947", "13.349768", "13.109707", "14.768771", "14.578289", "14.412329", "16.210753", "15.995111", "15.806612", "17.432961", "17.221614", "18.890398", "18.656", "18.448243", "20.108547", "19.879682", "21.578131", "21.104871", "23.530233", "23.047451", "25.482345", "24.992211", "27.434462", "26.937924"})
        Me.ISO_HBP_y.Location = New System.Drawing.Point(388, 260)
        Me.ISO_HBP_y.Name = "ISO_HBP_y"
        Me.ISO_HBP_y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_y.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_y.TabIndex = 36
        Me.ISO_HBP_y.Visible = False
        '
        'ISO_HBP_a
        '
        Me.ISO_HBP_a.ItemHeight = 16
        Me.ISO_HBP_a.Items.AddRange(New Object() {"6.214783", "7.014783", "8.750287", "9.750287", "10.521368", "11.721368", "12.425531", "13.825531", "14.602033", "16.202033", "17.802033", "18.859428", "20.659428", "22.459428", "23.659132", "25.659132", "28.659132", "29.001148", "32.301148", "32.485474", "34.885474", "37.285474", "36.11211", "38.71211", "41.31211", "42.681057", "45.481057", "46.792314", "49.792314", "52.792314", "54.245882", "57.445882", "58.84176", "65.64176", "69.70241", "77.10241", "81.483258", "89.483258", "94.184305", "102.784305"})
        Me.ISO_HBP_a.Location = New System.Drawing.Point(388, 216)
        Me.ISO_HBP_a.Name = "ISO_HBP_a"
        Me.ISO_HBP_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_a.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_a.TabIndex = 35
        Me.ISO_HBP_a.Visible = False
        '
        'ISO_HBP_i
        '
        Me.ISO_HBP_i.ItemHeight = 16
        Me.ISO_HBP_i.Items.AddRange(New Object() {"38.653703", "43.353409", "85.296851", "94.314883", "148.763344", "164.393339", "240.906951", "265.950667", "372.71879", "410.836163", "448.237386", "608.445917", "662.926914", "716.465252", "941.266559", "1016.22908", "1126.501864", "1394.729374", "1544.188534", "1862.606443", "1994.939305", "2125.066543", "2430.765301", "2602.235023", "2770.557584", "3328.592674", "3542.493099", "4186.202274", "4453.872155", "4716.692479", "5517.935723", "5842.00992", "6748.14293", "7530.968411", "9455.87449", "10469.36422", "12906.36138", "14191.98024", "17224.36191", "18827.0105"})
        Me.ISO_HBP_i.Location = New System.Drawing.Point(388, 176)
        Me.ISO_HBP_i.Name = "ISO_HBP_i"
        Me.ISO_HBP_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_i.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_i.TabIndex = 34
        Me.ISO_HBP_i.Visible = False
        '
        'ISO_HBP_flange_breadth
        '
        Me.ISO_HBP_flange_breadth.ItemHeight = 16
        Me.ISO_HBP_flange_breadth.Items.AddRange(New Object() {"14", "14", "15.5", "15.5", "17", "17", "19", "19", "22", "22", "22", "25", "25", "25", "28", "28", "28", "31", "31", "34", "34", "34", "37", "37", "37", "40", "40", "43", "43", "43", "46", "46", "49", "49", "53.5", "53.5", "58", "58", "62.5", "62.5"})
        Me.ISO_HBP_flange_breadth.Location = New System.Drawing.Point(320, 260)
        Me.ISO_HBP_flange_breadth.Name = "ISO_HBP_flange_breadth"
        Me.ISO_HBP_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_flange_breadth.TabIndex = 32
        Me.ISO_HBP_flange_breadth.Visible = False
        '
        'ISO_HBP_web_thickness
        '
        Me.ISO_HBP_web_thickness.ItemHeight = 16
        Me.ISO_HBP_web_thickness.Items.AddRange(New Object() {"6", "7", "7", "8", "7", "8", "7", "8", "7", "8", "9", "8", "9", "10", "9", "10", "11.5", "10", "11.5", "10", "11", "12", "10", "11", "12", "11", "12", "11", "12", "13", "12", "13", "12", "14", "13", "15", "14", "16", "15", "17"})
        Me.ISO_HBP_web_thickness.Location = New System.Drawing.Point(320, 216)
        Me.ISO_HBP_web_thickness.Name = "ISO_HBP_web_thickness"
        Me.ISO_HBP_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_web_thickness.TabIndex = 31
        Me.ISO_HBP_web_thickness.Visible = False
        '
        'ISO_HBP_bulb_radius
        '
        Me.ISO_HBP_bulb_radius.ItemHeight = 16
        Me.ISO_HBP_bulb_radius.Items.AddRange(New Object() {"4", "4", "4.5", "4.5", "5", "5", "5.5", "5.5", "6", "6", "6", "7", "7", "7", "8", "8", "8", "9", "9", "10", "10", "10", "11", "11", "11", "12", "12", "13", "13", "13", "14", "14", "15", "15", "16.5", "16.5", "18", "18", "19.5", "19.5"})
        Me.ISO_HBP_bulb_radius.Location = New System.Drawing.Point(320, 284)
        Me.ISO_HBP_bulb_radius.Name = "ISO_HBP_bulb_radius"
        Me.ISO_HBP_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_bulb_radius.TabIndex = 33
        Me.ISO_HBP_bulb_radius.Visible = False
        '
        'ISO_HBP_profile_depth
        '
        Me.ISO_HBP_profile_depth.ItemHeight = 16
        Me.ISO_HBP_profile_depth.Items.AddRange(New Object() {"80", "80", "100", "100", "120", "120", "140", "140", "160", "160", "160", "180", "180", "180", "200", "200", "200", "220", "220", "240", "240", "240", "260", "260", "260", "280", "280", "300", "300", "300", "320", "320", "340", "340", "370", "370", "400", "400", "430", "430"})
        Me.ISO_HBP_profile_depth.Location = New System.Drawing.Point(320, 176)
        Me.ISO_HBP_profile_depth.Name = "ISO_HBP_profile_depth"
        Me.ISO_HBP_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.ISO_HBP_profile_depth.TabIndex = 30
        Me.ISO_HBP_profile_depth.Visible = False
        '
        'DIN_HBP_y
        '
        Me.DIN_HBP_y.ItemHeight = 16
        Me.DIN_HBP_y.Items.AddRange(New Object() {"3.821157", "3.703267", "3.614977", "4.897135", "4.781651", "4.692508", "5.98617", "5.873469", "5.782885", "7.206165", "7.068597", "6.959197", "8.315387", "8.044353", "8.073485", "9.662187", "9.498041", "9.363401", "10.891839", "10.727008", "10.588598", "10.470727", "12.120983", "11.955663", "11.814251", "11.750947", "11.691911", "13.349758", "13.184085", "13.109707", "13.040228", "14.768771", "14.578289", "14.412329", "16.210753", "15.995111", "15.806612", "15.640435", "17.432961", "17.221614", "17.03478", "18.890398", "18.656", "18.448243", "18.262828", "20.108547", "19.879682", "19.674969", "19.490777", "21.578131", "21.328048", "21.103871", "20.901774", "23.530233", "23.276674", "23.047451", "22.83922", "25.482345", "25.225811", "24.99221", "24.778602", "27.434462", "26.937924", "26.518061", "26.158386"})
        Me.DIN_HBP_y.Location = New System.Drawing.Point(240, 260)
        Me.DIN_HBP_y.Name = "DIN_HBP_y"
        Me.DIN_HBP_y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_y.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_y.TabIndex = 28
        Me.DIN_HBP_y.Visible = False
        '
        'DIN_HBP_a
        '
        Me.DIN_HBP_a.ItemHeight = 16
        Me.DIN_HBP_a.Items.AddRange(New Object() {"3.579267", "4.179267", "4.779267", "5.414783", "6.214783", "7.014783", "7.750287", "8.750287", "9.750287", "9.321368", "10.5211368", "11.721368", "12.425531", "13.444177", "15.225531", "14.602033", "16.202033", "17.802033", "18.859428", "20.659428", "22.459428", "24.259428", "23.659132", "25.659132", "27.659132", "28.659132", "29.659132", "29.001148", "31.201148", "32.301148", "33.401148", "32.485474", "34.885474", "37.285474", "36.11211", "38.71211", "41.31211", "43.91211", "42.681057", "45.481057", "48.281057", "46.792314", "49.792314", "52.792314", "55.792314", "54.246882", "57.445882", "60.645882", "63.845882", "58.84176", "62.24176", "65.64176", "69.04176", "69.70241", "73.40241", "77.10241", "80.80241", "81.483259", "85.482258", "89.483258", "93.483258", "94.184305", "102.784305", "111.384305", "119.984305"})
        Me.DIN_HBP_a.Location = New System.Drawing.Point(240, 216)
        Me.DIN_HBP_a.Name = "DIN_HBP_a"
        Me.DIN_HBP_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_a.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_a.TabIndex = 27
        Me.DIN_HBP_a.Visible = False
        '
        'DIN_HBP_i
        '
        Me.DIN_HBP_i.ItemHeight = 16
        Me.DIN_HBP_i.Items.AddRange(New Object() {"12.227612", "14.374108", "16.433604", "33.826039", "38.653703", "43.353409", "76.102129", "85.296851", "94.314883", "132.816659", "148.763344", "164.393339", "240.906951", "256.571244", "290.59402", "372.71879", "410.836163", "448.237386", "608.445917", "662.926914", "716.465252", "769.270761", "941.266559", "1016.22908", "1089.991874", "1126.501864", "1162.797643", "1394.72937", "1494.75331", "1544.188534", "1593.289912", "1862.606443", "1994.939305", "2125.066543", "2430.765301", "2602.235023", "2770.557584", "2936.292005", "3328.592674", "3542.493099", "3752.801727", "4186.202274", "4453.872155", "4716.692479", "4975.445541", "5517.935723", "5842.00992", "6160.701259", "6474.819177", "6748.14293", "7143.045128", "7530.968411", "7912.943821", "9455.87449", "9966.885632", "10469.36422", "10964.48238", "12906.36138", "13554.2935", "14191.98024", "14820.73675", "17224.36191", "18827.0105", "20386.80251", "21912.95333"})
        Me.DIN_HBP_i.Location = New System.Drawing.Point(240, 176)
        Me.DIN_HBP_i.Name = "DIN_HBP_i"
        Me.DIN_HBP_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_i.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_i.TabIndex = 26
        Me.DIN_HBP_i.Visible = False
        '
        'box12
        '
        Me.box12.Controls.Add(Me.label_y12_unit)
        Me.box12.Controls.Add(Me.textbox_a12)
        Me.box12.Controls.Add(Me.label_a12_unit)
        Me.box12.Controls.Add(Me.textbox_y12)
        Me.box12.Controls.Add(Me.label_m12_unit)
        Me.box12.Controls.Add(Me.textbox_m12)
        Me.box12.Controls.Add(Me.label_y12)
        Me.box12.Controls.Add(Me.label_a12)
        Me.box12.Controls.Add(Me.label_m12)
        Me.box12.Font = New System.Drawing.Font("David", 10.8!)
        Me.box12.Location = New System.Drawing.Point(207, 38)
        Me.box12.Name = "box12"
        Me.box12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box12.Size = New System.Drawing.Size(364, 136)
        Me.box12.TabIndex = 25
        Me.box12.TabStop = False
        Me.box12.Text = "נתוני החיזוק"
        '
        'label_y12_unit
        '
        Me.label_y12_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y12_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y12_unit.Name = "label_y12_unit"
        Me.label_y12_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y12_unit.TabIndex = 8
        Me.label_y12_unit.Text = "[cm]"
        '
        'textbox_a12
        '
        Me.textbox_a12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a12.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a12.Name = "textbox_a12"
        Me.textbox_a12.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a12.TabIndex = 7
        '
        'label_a12_unit
        '
        Me.label_a12_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a12_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a12_unit.Name = "label_a12_unit"
        Me.label_a12_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a12_unit.TabIndex = 6
        Me.label_a12_unit.Text = "[cm^2]"
        '
        'textbox_y12
        '
        Me.textbox_y12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y12.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y12.Name = "textbox_y12"
        Me.textbox_y12.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y12.TabIndex = 5
        '
        'label_m12_unit
        '
        Me.label_m12_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m12_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m12_unit.Name = "label_m12_unit"
        Me.label_m12_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m12_unit.TabIndex = 4
        Me.label_m12_unit.Text = "[cm^4]"
        '
        'textbox_m12
        '
        Me.textbox_m12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m12.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m12.Name = "textbox_m12"
        Me.textbox_m12.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m12.TabIndex = 3
        '
        'label_y12
        '
        Me.label_y12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y12.Location = New System.Drawing.Point(188, 94)
        Me.label_y12.Name = "label_y12"
        Me.label_y12.Size = New System.Drawing.Size(164, 24)
        Me.label_y12.TabIndex = 2
        Me.label_y12.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a12
        '
        Me.label_a12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a12.Location = New System.Drawing.Point(188, 63)
        Me.label_a12.Name = "label_a12"
        Me.label_a12.Size = New System.Drawing.Size(164, 24)
        Me.label_a12.TabIndex = 1
        Me.label_a12.Text = "שטח חתך החיזוק"
        '
        'label_m12
        '
        Me.label_m12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m12.Location = New System.Drawing.Point(188, 32)
        Me.label_m12.Name = "label_m12"
        Me.label_m12.Size = New System.Drawing.Size(164, 24)
        Me.label_m12.TabIndex = 0
        Me.label_m12.Text = "מומנט אינרציה (Ix)"
        '
        'Label_title12
        '
        Me.Label_title12.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title12.Location = New System.Drawing.Point(12, 20)
        Me.Label_title12.Name = "Label_title12"
        Me.Label_title12.Size = New System.Drawing.Size(196, 20)
        Me.Label_title12.TabIndex = 24
        Me.Label_title12.Text = "שם החיזוק לפי התקן"
        '
        'DIN_HBP_names
        '
        Me.DIN_HBP_names.ItemHeight = 16
        Me.DIN_HBP_names.Items.AddRange(New Object() {"60.0 x 4.0 HP", "60.0 x 5.0 HP", "60.0 x 6.0 HP", "80.0 x 5.0 HP", "80.0 x 6.0 HP", "80.0 x 7.0 HP", "100.0 x 6.0 HP", "100.0 x 7.0 HP", "100.0 x 8.0 HP", "120.0 x 6.0 HP", "120.0 x 7.0 HP", "120.0 x 8.0 HP", "140.0 x 7.0 HP", "140.0 x 8.0 HP", "140.0 x 9.0 HP", "160.0 x 7.0 HP", "160.0 x 8.0 HP", "160.0 x 9.0 HP", "180.0 x 8.0 HP", "180.0 x 9.0 HP", "180.0 x 10.0 HP", "180.0 x 11.0 HP", "200.0 x 9.0 HP", "200.0 x 10.0 HP", "200.0 x 11.0 HP", "200.0 x 11.5 HP", "200.0 x 12.0 HP", "220.0 x 10.0 HP", "220.0 x 11.0 HP", "220.0 x 11.5 HP", "220.0 x 12.0 HP", "240.0 x 10.0 HP", "240.0 x 11.0 HP", "240.0 x 12.0 HP", "260.0 x 10.0 HP", "260.0 x 11.0 HP", "260.0 x 12.0 HP", "260.0 x 13.0 HP", "280.0 x 11.0 HP", "280.0 x 12.0 HP", "280.0 x 13.0 HP", "300.0 x 11.0 HP", "300.0 x 12.0 HP", "300.0 x 13.0 HP", "300.0 x 14.0 HP", "320.0 x 12.0 HP", "320.0 x 13.0 HP", "320.0 x 14.0 HP", "320.0 x 15.0 HP", "340.0 x 12.0 HP", "340.0 x 13.0 HP", "340.0 x 14.0 HP", "340.0 x 15.0 HP", "370.0 x 13.0 HP", "370.0 x 14.0 HP", "370.0 x 15.0 HP", "370.0 x 16.0 HP", "400.0 x 14.0 HP", "400.0 x 15.0 HP", "400.0 x 16.0 HP", "400.0 x 17.0 HP", "430.0 x 15.0 HP", "430.0 x 17.0 HP", "430.0 x 19.0 HP", "430.0 x 21.0 HP"})
        Me.DIN_HBP_names.Location = New System.Drawing.Point(15, 46)
        Me.DIN_HBP_names.Name = "DIN_HBP_names"
        Me.DIN_HBP_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_names.Size = New System.Drawing.Size(189, 276)
        Me.DIN_HBP_names.TabIndex = 16
        '
        'DIN_HBP_flange_breadth
        '
        Me.DIN_HBP_flange_breadth.ItemHeight = 16
        Me.DIN_HBP_flange_breadth.Items.AddRange(New Object() {"13", "13", "13", "14", "14", "14", "15.5", "15.5", "15.5", "17", "17", "17", "19", "17", "19", "22", "22", "22", "25", "25", "25", "25", "28", "28", "28", "28", "28", "31", "31", "31", "31", "34", "34", "34", "37", "37", "37", "37", "40", "40", "40", "43", "43", "43", "43", "46", "46", "46", "46", "49", "49", "49", "49", "53.5", "53.5", "53.5", "53.5", "58", "58", "58", "58", "62.5", "62.5", "62.5", "62.5"})
        Me.DIN_HBP_flange_breadth.Location = New System.Drawing.Point(172, 260)
        Me.DIN_HBP_flange_breadth.Name = "DIN_HBP_flange_breadth"
        Me.DIN_HBP_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_flange_breadth.TabIndex = 19
        Me.DIN_HBP_flange_breadth.Visible = False
        '
        'DIN_HBP_web_thickness
        '
        Me.DIN_HBP_web_thickness.ItemHeight = 16
        Me.DIN_HBP_web_thickness.Items.AddRange(New Object() {"4", "5", "6", "5", "6", "7", "6", "7", "8", "6", "7", "8", "7", "8", "9", "7", "8", "9", "8", "9", "10", "11", "9", "10", "11", "11.5", "12", "10", "11", "11.5", "12", "10", "11", "12", "10", "11", "12", "13", "11", "12", "13", "11", "12", "13", "14", "12", "13", "14", "15", "12", "13", "14", "15", "13", "14", "15", "16", "14", "15", "16", "17", "15", "17", "19", "21"})
        Me.DIN_HBP_web_thickness.Location = New System.Drawing.Point(172, 216)
        Me.DIN_HBP_web_thickness.Name = "DIN_HBP_web_thickness"
        Me.DIN_HBP_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_web_thickness.TabIndex = 18
        Me.DIN_HBP_web_thickness.Visible = False
        '
        'DIN_HBP_bulb_radius
        '
        Me.DIN_HBP_bulb_radius.ItemHeight = 16
        Me.DIN_HBP_bulb_radius.Items.AddRange(New Object() {"3.5", "3.5", "3.5", "4", "4", "4", "4.5", "4.5", "4.5", "5", "5", "5", "5.5", "5.5", "5.5", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "11", "11", "11", "11", "12", "12", "12", "13", "13", "13", "13", "14", "14", "14", "14", "15", "15", "15", "15", "16.5", "16.5", "16.5", "16.5", "18", "18", "18", "18", "19.5", "19.5", "19.5", "19.5"})
        Me.DIN_HBP_bulb_radius.Location = New System.Drawing.Point(176, 284)
        Me.DIN_HBP_bulb_radius.Name = "DIN_HBP_bulb_radius"
        Me.DIN_HBP_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_bulb_radius.TabIndex = 20
        Me.DIN_HBP_bulb_radius.Visible = False
        '
        'DIN_HBP_profile_depth
        '
        Me.DIN_HBP_profile_depth.ItemHeight = 16
        Me.DIN_HBP_profile_depth.Items.AddRange(New Object() {"60", "60", "60", "80", "80", "80", "100", "100", "100", "120", "120", "120", "140", "140", "140", "160", "160", "160", "180", "180", "180", "180", "200", "200", "200", "200", "200", "220", "220", "220", "220", "240", "240", "240", "260", "260", "260", "260", "280", "280", "280", "300", "300", "300", "300", "320", "320", "320", "320", "340", "340", "340", "340", "370", "370", "370", "370", "400", "400", "400", "400", "430", "430", "430", "430"})
        Me.DIN_HBP_profile_depth.Location = New System.Drawing.Point(172, 176)
        Me.DIN_HBP_profile_depth.Name = "DIN_HBP_profile_depth"
        Me.DIN_HBP_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DIN_HBP_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.DIN_HBP_profile_depth.TabIndex = 17
        Me.DIN_HBP_profile_depth.Visible = False
        '
        'bulb_pic01
        '
        Me.bulb_pic01.Controls.Add(Me.bulb_radius_din_label)
        Me.bulb_pic01.Controls.Add(Me.bulb_flange_breadth_label)
        Me.bulb_pic01.Controls.Add(Me.bulb_profile_depth_label)
        Me.bulb_pic01.Controls.Add(Me.bulb_web_thickness_label)
        Me.bulb_pic01.Controls.Add(Me.PictureBox8)
        Me.bulb_pic01.Location = New System.Drawing.Point(580, 40)
        Me.bulb_pic01.Name = "bulb_pic01"
        Me.bulb_pic01.Size = New System.Drawing.Size(276, 280)
        Me.bulb_pic01.TabIndex = 23
        Me.bulb_pic01.TabStop = False
        Me.bulb_pic01.Text = "Profile: British Standard EA"
        '
        'bulb_radius_din_label
        '
        Me.bulb_radius_din_label.AutoEllipsis = True
        Me.bulb_radius_din_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb_radius_din_label.Location = New System.Drawing.Point(200, 76)
        Me.bulb_radius_din_label.Name = "bulb_radius_din_label"
        Me.bulb_radius_din_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb_radius_din_label.Size = New System.Drawing.Size(64, 20)
        Me.bulb_radius_din_label.TabIndex = 15
        '
        'bulb_flange_breadth_label
        '
        Me.bulb_flange_breadth_label.AutoEllipsis = True
        Me.bulb_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb_flange_breadth_label.Location = New System.Drawing.Point(116, 40)
        Me.bulb_flange_breadth_label.Name = "bulb_flange_breadth_label"
        Me.bulb_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb_flange_breadth_label.Size = New System.Drawing.Size(72, 21)
        Me.bulb_flange_breadth_label.TabIndex = 14
        '
        'bulb_profile_depth_label
        '
        Me.bulb_profile_depth_label.AutoEllipsis = True
        Me.bulb_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb_profile_depth_label.Location = New System.Drawing.Point(28, 140)
        Me.bulb_profile_depth_label.Name = "bulb_profile_depth_label"
        Me.bulb_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb_profile_depth_label.Size = New System.Drawing.Size(64, 19)
        Me.bulb_profile_depth_label.TabIndex = 12
        '
        'bulb_web_thickness_label
        '
        Me.bulb_web_thickness_label.AutoEllipsis = True
        Me.bulb_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb_web_thickness_label.Location = New System.Drawing.Point(92, 240)
        Me.bulb_web_thickness_label.Name = "bulb_web_thickness_label"
        Me.bulb_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb_web_thickness_label.Size = New System.Drawing.Size(64, 20)
        Me.bulb_web_thickness_label.TabIndex = 11
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(96, 64)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 176)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'ISO_HBP_names
        '
        Me.ISO_HBP_names.ItemHeight = 16
        Me.ISO_HBP_names.Items.AddRange(New Object() {"80.0 x 6.0 HP", "80.0 x 7.0 HP", "100.0 x 7.0 HP", "100.0 x 8.0 HP", "120.0 x 7.0 HP", "120.0 x 8.0 HP", "140.0 x 7.0 HP", "140.0 x 8.0 HP", "160.0 x 7.0 HP", "160.0 x 8.0 HP", "160.0 x 9.0 HP", "180.0 x 8.0 HP", "180.0 x 9.0 HP", "180.0 x 10.0 HP", "200.0 x 9.0 HP", "200.0 x 10.0 HP", "200.0 x 11.5 HP", "220.0 x 10.0 HP", "220.0 x 11.5 HP", "240.0 x 10.0 HP", "240.0 x 11.0 HP", "240.0 x 12.0 HP", "260.0 x 10.0 HP", "260.0 x 11.0 HP", "260.0 x 12.0 HP", "280.0 x 11.0 HP", "280.0 x 12.0 HP", "300.0 x 11.0 HP", "300.0 x 12.0 HP", "300.0 x 13.0 HP", "320.0 x 12.0 HP", "320.0 x 13.0 HP", "340.0 x 12.0 HP", "340.0 x 14.0 HP", "370.0 x 13.0 HP", "370.0 x 15.0 HP", "400.0 x 14.0 HP", "400.0 x 16.0 HP", "430.0 x 15.0 HP", "430.0 x 17.0 HP"})
        Me.ISO_HBP_names.Location = New System.Drawing.Point(15, 46)
        Me.ISO_HBP_names.Name = "ISO_HBP_names"
        Me.ISO_HBP_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ISO_HBP_names.Size = New System.Drawing.Size(189, 276)
        Me.ISO_HBP_names.TabIndex = 29
        '
        'FDA_bulb02
        '
        Me.FDA_bulb02.Controls.Add(Me.box13)
        Me.FDA_bulb02.Controls.Add(Me.Label_title13)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_a)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_centroid)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_i)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_flange_breadth)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_web_thickness)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_bulb_radius)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_profile_depth)
        Me.FDA_bulb02.Controls.Add(Me.bulb02_names)
        Me.FDA_bulb02.Controls.Add(Me.FDA_bulb02_picbox)
        Me.FDA_bulb02.Location = New System.Drawing.Point(6, 12)
        Me.FDA_bulb02.Name = "FDA_bulb02"
        Me.FDA_bulb02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_bulb02.Size = New System.Drawing.Size(868, 356)
        Me.FDA_bulb02.TabIndex = 12
        Me.FDA_bulb02.TabStop = False
        Me.FDA_bulb02.Text = "DIN Bulbs"
        Me.FDA_bulb02.Visible = False
        '
        'box13
        '
        Me.box13.Controls.Add(Me.box13_y13)
        Me.box13.Controls.Add(Me.box13_a13)
        Me.box13.Controls.Add(Me.box13_m13)
        Me.box13.Font = New System.Drawing.Font("David", 10.8!)
        Me.box13.Location = New System.Drawing.Point(361, 38)
        Me.box13.Name = "box13"
        Me.box13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box13.Size = New System.Drawing.Size(208, 188)
        Me.box13.TabIndex = 25
        Me.box13.TabStop = False
        Me.box13.Text = "נתוני החיזוק"
        '
        'box13_y13
        '
        Me.box13_y13.Controls.Add(Me.textbox_y13)
        Me.box13_y13.Controls.Add(Me.label_y13_unit)
        Me.box13_y13.Location = New System.Drawing.Point(8, 132)
        Me.box13_y13.Name = "box13_y13"
        Me.box13_y13.Size = New System.Drawing.Size(188, 52)
        Me.box13_y13.TabIndex = 11
        Me.box13_y13.TabStop = False
        Me.box13_y13.Text = "מיקום מרכז השטח"
        '
        'textbox_y13
        '
        Me.textbox_y13.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y13.Location = New System.Drawing.Point(85, 20)
        Me.textbox_y13.Name = "textbox_y13"
        Me.textbox_y13.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y13.TabIndex = 5
        '
        'label_y13_unit
        '
        Me.label_y13_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y13_unit.Location = New System.Drawing.Point(12, 24)
        Me.label_y13_unit.Name = "label_y13_unit"
        Me.label_y13_unit.Size = New System.Drawing.Size(60, 25)
        Me.label_y13_unit.TabIndex = 8
        Me.label_y13_unit.Text = "[cm]"
        Me.label_y13_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'box13_a13
        '
        Me.box13_a13.Controls.Add(Me.label_a13_unit)
        Me.box13_a13.Controls.Add(Me.textbox_a13)
        Me.box13_a13.Location = New System.Drawing.Point(8, 76)
        Me.box13_a13.Name = "box13_a13"
        Me.box13_a13.Size = New System.Drawing.Size(188, 52)
        Me.box13_a13.TabIndex = 10
        Me.box13_a13.TabStop = False
        Me.box13_a13.Text = "שטח חתך החיזוק"
        '
        'label_a13_unit
        '
        Me.label_a13_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a13_unit.Location = New System.Drawing.Point(12, 24)
        Me.label_a13_unit.Name = "label_a13_unit"
        Me.label_a13_unit.Size = New System.Drawing.Size(60, 25)
        Me.label_a13_unit.TabIndex = 6
        Me.label_a13_unit.Text = "[cm^2]"
        Me.label_a13_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textbox_a13
        '
        Me.textbox_a13.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a13.Location = New System.Drawing.Point(85, 20)
        Me.textbox_a13.Name = "textbox_a13"
        Me.textbox_a13.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a13.TabIndex = 7
        '
        'box13_m13
        '
        Me.box13_m13.Controls.Add(Me.Label_m13_unit)
        Me.box13_m13.Controls.Add(Me.textbox_m13)
        Me.box13_m13.Location = New System.Drawing.Point(8, 21)
        Me.box13_m13.Name = "box13_m13"
        Me.box13_m13.Size = New System.Drawing.Size(188, 52)
        Me.box13_m13.TabIndex = 9
        Me.box13_m13.TabStop = False
        Me.box13_m13.Text = "מומנט אינרציה (Ix)"
        '
        'Label_m13_unit
        '
        Me.Label_m13_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_m13_unit.Location = New System.Drawing.Point(12, 20)
        Me.Label_m13_unit.Name = "Label_m13_unit"
        Me.Label_m13_unit.Size = New System.Drawing.Size(56, 25)
        Me.Label_m13_unit.TabIndex = 4
        Me.Label_m13_unit.Text = "[cm^4]"
        Me.Label_m13_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textbox_m13
        '
        Me.textbox_m13.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m13.Location = New System.Drawing.Point(85, 20)
        Me.textbox_m13.Name = "textbox_m13"
        Me.textbox_m13.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m13.TabIndex = 3
        '
        'Label_title13
        '
        Me.Label_title13.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title13.Location = New System.Drawing.Point(12, 20)
        Me.Label_title13.Name = "Label_title13"
        Me.Label_title13.Size = New System.Drawing.Size(312, 20)
        Me.Label_title13.TabIndex = 24
        Me.Label_title13.Text = "שם החיזוק לפי התקן"
        '
        'bulb02_a
        '
        Me.bulb02_a.ItemHeight = 16
        Me.bulb02_a.Items.AddRange(New Object() {"21.06147", "25.233859", "31.983094", "38.134326", "21.06147", "25.233859", "31.983094", "38.134326", "115.383268", "122.464972", "130.964972", "140.883268", "149.383268", "157.883268", "24.259066", "41.645061", "44.440546", "47.241805", "50.048837", "52.861642", "44.645061", "47.740546", "50.841805", "53.948837", "57.061642", "48.645061", "52.149546", "55.641805", "59.148837", "62.661642"})
        Me.bulb02_a.Location = New System.Drawing.Point(124, 252)
        Me.bulb02_a.Name = "bulb02_a"
        Me.bulb02_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_a.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_a.TabIndex = 28
        Me.bulb02_a.Visible = False
        '
        'bulb02_centroid
        '
        Me.bulb02_centroid.ItemHeight = 16
        Me.bulb02_centroid.Items.AddRange(New Object() {"10.510836", "11.8441", "13.64167", "14.871036", "10.510836", "11.8441", "13.64167", "14.871036", "27.067767", "29.94117", "32.835646", "35.81097", "38.631052", "41.41667", "10.308976", "15.840666", "15.668147", "15.516353", "15.381851", "15.261923", "17.675431", "17.481422", "17.311462", "17.165145", "17.028168", "20.057554", "19.837438", "19.645538", "19.476894", "19.327642"})
        Me.bulb02_centroid.Location = New System.Drawing.Point(124, 208)
        Me.bulb02_centroid.Name = "bulb02_centroid"
        Me.bulb02_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_centroid.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_centroid.TabIndex = 27
        Me.bulb02_centroid.Visible = False
        '
        'bulb02_i
        '
        Me.bulb02_i.ItemHeight = 16
        Me.bulb02_i.Items.AddRange(New Object() {"670.604843", "996.98586", "1674.569165", "2358.983827", "670.604843", "996.98586", "1674.569165", "2358.983827", "17495.16253", "24339.00314", "327321.7642", "42928.78641", "54712.32772", "68335.84633", "595.889091", "2006.932883", "2162.198653", "2315.168635", "2466.244018", "2615.741454", "2850.661087", "3070.099286", "3286.460934", "3500.306636", "3712.075666", "4277.154989", "4604.960021", "4928.514314", "5248.629597", "5565.936746"})
        Me.bulb02_i.Location = New System.Drawing.Point(124, 168)
        Me.bulb02_i.Name = "bulb02_i"
        Me.bulb02_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_i.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_i.TabIndex = 26
        Me.bulb02_i.Visible = False
        '
        'bulb02_flange_breadth
        '
        Me.bulb02_flange_breadth.ItemHeight = 16
        Me.bulb02_flange_breadth.Items.AddRange(New Object() {"23", "26.5", "30", "33", "23", "26.5", "30", "33", "98", "96", "96", "98", "98", "98", "38", "58", "59", "60", "61", "62", "58", "59", "60", "61", "62", "58", "59", "60", "61", "62"})
        Me.bulb02_flange_breadth.Location = New System.Drawing.Point(56, 252)
        Me.bulb02_flange_breadth.Name = "bulb02_flange_breadth"
        Me.bulb02_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_flange_breadth.TabIndex = 19
        Me.bulb02_flange_breadth.Visible = False
        '
        'bulb02_web_thickness
        '
        Me.bulb02_web_thickness.ItemHeight = 16
        Me.bulb02_web_thickness.Items.AddRange(New Object() {"9.5", "10", "11", "12", "9.5", "10", "11", "12", "17", "17", "17", "17", "17", "17", "10", "10", "11", "12", "13", "14", "10", "11", "12", "13", "14", "10", "11", "12", "13", "14"})
        Me.bulb02_web_thickness.Location = New System.Drawing.Point(56, 208)
        Me.bulb02_web_thickness.Name = "bulb02_web_thickness"
        Me.bulb02_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_web_thickness.TabIndex = 18
        Me.bulb02_web_thickness.Visible = False
        '
        'bulb02_bulb_radius
        '
        Me.bulb02_bulb_radius.ItemHeight = 16
        Me.bulb02_bulb_radius.Items.AddRange(New Object() {"7", "8", "9", "10", "7", "8", "9", "10", "12", "14", "14", "12", "12", "12", "7", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10"})
        Me.bulb02_bulb_radius.Location = New System.Drawing.Point(56, 292)
        Me.bulb02_bulb_radius.Name = "bulb02_bulb_radius"
        Me.bulb02_bulb_radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_bulb_radius.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_bulb_radius.TabIndex = 20
        Me.bulb02_bulb_radius.Visible = False
        '
        'bulb02_profile_depth
        '
        Me.bulb02_profile_depth.ItemHeight = 16
        Me.bulb02_profile_depth.Items.AddRange(New Object() {"180", "200", "230", "250", "180", "200", "230", "250", "400", "450", "500", "550", "600", "650", "160", "230", "230", "230", "230", "230", "260", "260", "260", "260", "260", "300", "300", "300", "300", "300"})
        Me.bulb02_profile_depth.Location = New System.Drawing.Point(56, 168)
        Me.bulb02_profile_depth.Name = "bulb02_profile_depth"
        Me.bulb02_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_profile_depth.TabIndex = 17
        Me.bulb02_profile_depth.Visible = False
        '
        'FDA_bulb02_picbox
        '
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_bulb_radius_label)
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_flange_breadth_label)
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_profile_depth_label)
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_web_thickness_label)
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_pic01)
        Me.FDA_bulb02_picbox.Controls.Add(Me.bulb02_pic02)
        Me.FDA_bulb02_picbox.Location = New System.Drawing.Point(580, 40)
        Me.FDA_bulb02_picbox.Name = "FDA_bulb02_picbox"
        Me.FDA_bulb02_picbox.Size = New System.Drawing.Size(276, 280)
        Me.FDA_bulb02_picbox.TabIndex = 23
        Me.FDA_bulb02_picbox.TabStop = False
        Me.FDA_bulb02_picbox.Text = "Profile: British Standard EA"
        '
        'bulb02_bulb_radius_label
        '
        Me.bulb02_bulb_radius_label.AutoEllipsis = True
        Me.bulb02_bulb_radius_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb02_bulb_radius_label.Location = New System.Drawing.Point(204, 56)
        Me.bulb02_bulb_radius_label.Name = "bulb02_bulb_radius_label"
        Me.bulb02_bulb_radius_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_bulb_radius_label.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_bulb_radius_label.TabIndex = 15
        '
        'bulb02_flange_breadth_label
        '
        Me.bulb02_flange_breadth_label.AutoEllipsis = True
        Me.bulb02_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb02_flange_breadth_label.Location = New System.Drawing.Point(124, 20)
        Me.bulb02_flange_breadth_label.Name = "bulb02_flange_breadth_label"
        Me.bulb02_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_flange_breadth_label.Size = New System.Drawing.Size(72, 21)
        Me.bulb02_flange_breadth_label.TabIndex = 14
        '
        'bulb02_profile_depth_label
        '
        Me.bulb02_profile_depth_label.AutoEllipsis = True
        Me.bulb02_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb02_profile_depth_label.Location = New System.Drawing.Point(29, 148)
        Me.bulb02_profile_depth_label.Name = "bulb02_profile_depth_label"
        Me.bulb02_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_profile_depth_label.Size = New System.Drawing.Size(67, 19)
        Me.bulb02_profile_depth_label.TabIndex = 12
        '
        'bulb02_web_thickness_label
        '
        Me.bulb02_web_thickness_label.AutoEllipsis = True
        Me.bulb02_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.bulb02_web_thickness_label.Location = New System.Drawing.Point(104, 248)
        Me.bulb02_web_thickness_label.Name = "bulb02_web_thickness_label"
        Me.bulb02_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_web_thickness_label.Size = New System.Drawing.Size(64, 20)
        Me.bulb02_web_thickness_label.TabIndex = 11
        '
        'bulb02_pic02
        '
        Me.bulb02_pic02.Image = CType(resources.GetObject("bulb02_pic02.Image"), System.Drawing.Image)
        Me.bulb02_pic02.Location = New System.Drawing.Point(100, 44)
        Me.bulb02_pic02.Name = "bulb02_pic02"
        Me.bulb02_pic02.Size = New System.Drawing.Size(100, 204)
        Me.bulb02_pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bulb02_pic02.TabIndex = 16
        Me.bulb02_pic02.TabStop = False
        '
        'bulb02_pic01
        '
        Me.bulb02_pic01.Image = CType(resources.GetObject("bulb02_pic01.Image"), System.Drawing.Image)
        Me.bulb02_pic01.Location = New System.Drawing.Point(100, 44)
        Me.bulb02_pic01.Name = "bulb02_pic01"
        Me.bulb02_pic01.Size = New System.Drawing.Size(100, 204)
        Me.bulb02_pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bulb02_pic01.TabIndex = 2
        Me.bulb02_pic01.TabStop = False
        '
        'bulb02_names
        '
        Me.bulb02_names.ItemHeight = 16
        Me.bulb02_names.Items.AddRange(New Object() {"180.0 x 9.5 HP (Japanese Standard HBP)", "200.0 x 10.0 HP (Japanese Standard HBP)", "230.0 x 11.0 HP (Japanese Standard HBP)", "250.0 x 12.0 HP (Japanese Standard HBP)", "180.0 x 9.5 HP (Korean Standard HPB)", "200.0 x 10.0 HP (Korean Standard HPB)", "230.0 x 11.0 HP (Korean Standard HPB)", "250.0 x 12.0 HP (Korean Standard HPB)", "400.0 x 17.0 HP (Nordic Jumbo PB)", "450.0 x 17.0 HP (Nordic Jumbo PB)", "500.0 x 17.0 HP (Nordic Jumbo PB)", "550.0 x 17.0 HP (Nordic Jumbo PB)", "600.0 x 17.0 HP (Nordic Jumbo PB)", "650.0 x 17.0 HP (Nordic Jumbo PB)", "160.0 x 10.0 HP (Polish Standard HPB)", "230.0 x 10.0 HP (Polish Standard HPB)", "230.0 x 11.0 HP (Polish Standard HPB)", "230.0 x 12.0 HP (Polish Standard HPB)", "230.0 x 13.0 HP (Polish Standard HPB)", "230.0 x 14.0 HP (Polish Standard HPB)", "260.0 x 10.0 HP (Polish Standard HPB)", "260.0 x 11.0 HP (Polish Standard HPB)", "260.0 x 12.0 HP (Polish Standard HPB)", "260.0 x 13.0 HP (Polish Standard HPB)", "260.0 x 14.0 HP (Polish Standard HPB)", "300.0 x 10.0 HP (Polish Standard HPB)", "300.0 x 11.0 HP (Polish Standard HPB)", "300.0 x 12.0 HP (Polish Standard HPB)", "300.0 x 13.0 HP (Polish Standard HPB)", "300.0 x 14.0 HP (Polish Standard HPB)"})
        Me.bulb02_names.Location = New System.Drawing.Point(15, 46)
        Me.bulb02_names.Name = "bulb02_names"
        Me.bulb02_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bulb02_names.Size = New System.Drawing.Size(310, 276)
        Me.bulb02_names.TabIndex = 29
        '
        'IP_T
        '
        Me.IP_T.Controls.Add(Me.box03)
        Me.IP_T.Controls.Add(Me.T_flange_breadth)
        Me.IP_T.Controls.Add(Me.Label_title03)
        Me.IP_T.Controls.Add(Me.T_centroid)
        Me.IP_T.Controls.Add(Me.T_a)
        Me.IP_T.Controls.Add(Me.T_i)
        Me.IP_T.Controls.Add(Me.ListBox5)
        Me.IP_T.Controls.Add(Me.T_flange_thickness)
        Me.IP_T.Controls.Add(Me.T_web_thickness)
        Me.IP_T.Controls.Add(Me.T_web_depth)
        Me.IP_T.Controls.Add(Me.IP_T_names)
        Me.IP_T.Controls.Add(Me.IP_T_groupbox)
        Me.IP_T.Location = New System.Drawing.Point(6, 12)
        Me.IP_T.Name = "IP_T"
        Me.IP_T.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_T.Size = New System.Drawing.Size(868, 356)
        Me.IP_T.TabIndex = 13
        Me.IP_T.TabStop = False
        Me.IP_T.Text = "Inexa Profil - T section"
        Me.IP_T.Visible = False
        '
        'box03
        '
        Me.box03.Controls.Add(Me.label_y03_unit)
        Me.box03.Controls.Add(Me.textbox_y03)
        Me.box03.Controls.Add(Me.label_a03_unit)
        Me.box03.Controls.Add(Me.textbox_a03)
        Me.box03.Controls.Add(Me.label_m03_unit)
        Me.box03.Controls.Add(Me.textbox_m03)
        Me.box03.Controls.Add(Me.label_y03)
        Me.box03.Controls.Add(Me.label_a03)
        Me.box03.Controls.Add(Me.label_m03)
        Me.box03.Font = New System.Drawing.Font("David", 10.8!)
        Me.box03.Location = New System.Drawing.Point(207, 38)
        Me.box03.Name = "box03"
        Me.box03.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box03.Size = New System.Drawing.Size(364, 136)
        Me.box03.TabIndex = 15
        Me.box03.TabStop = False
        Me.box03.Text = "נתוני החיזוק"
        '
        'label_y03_unit
        '
        Me.label_y03_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y03_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y03_unit.Name = "label_y03_unit"
        Me.label_y03_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_y03_unit.TabIndex = 8
        Me.label_y03_unit.Text = "[cm]"
        '
        'textbox_y03
        '
        Me.textbox_y03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y03.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y03.Name = "textbox_y03"
        Me.textbox_y03.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y03.TabIndex = 7
        '
        'label_a03_unit
        '
        Me.label_a03_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a03_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a03_unit.Name = "label_a03_unit"
        Me.label_a03_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_a03_unit.TabIndex = 6
        Me.label_a03_unit.Text = "[cm^2]"
        '
        'textbox_a03
        '
        Me.textbox_a03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a03.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a03.Name = "textbox_a03"
        Me.textbox_a03.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a03.TabIndex = 5
        '
        'label_m03_unit
        '
        Me.label_m03_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m03_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m03_unit.Name = "label_m03_unit"
        Me.label_m03_unit.Size = New System.Drawing.Size(56, 24)
        Me.label_m03_unit.TabIndex = 4
        Me.label_m03_unit.Text = "[cm^4]"
        '
        'textbox_m03
        '
        Me.textbox_m03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m03.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m03.Name = "textbox_m03"
        Me.textbox_m03.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m03.TabIndex = 3
        '
        'label_y03
        '
        Me.label_y03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y03.Location = New System.Drawing.Point(188, 94)
        Me.label_y03.Name = "label_y03"
        Me.label_y03.Size = New System.Drawing.Size(164, 24)
        Me.label_y03.TabIndex = 2
        Me.label_y03.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a03
        '
        Me.label_a03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a03.Location = New System.Drawing.Point(188, 63)
        Me.label_a03.Name = "label_a03"
        Me.label_a03.Size = New System.Drawing.Size(164, 24)
        Me.label_a03.TabIndex = 1
        Me.label_a03.Text = "שטח חתך החיזוק"
        '
        'label_m03
        '
        Me.label_m03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m03.Location = New System.Drawing.Point(188, 32)
        Me.label_m03.Name = "label_m03"
        Me.label_m03.Size = New System.Drawing.Size(164, 24)
        Me.label_m03.TabIndex = 0
        Me.label_m03.Text = "מומנט אינרציה (Ix)"
        '
        'T_flange_breadth
        '
        Me.T_flange_breadth.ItemHeight = 16
        Me.T_flange_breadth.Items.AddRange(New Object() {"100", "120", "120", "120", "120", "120", "120", "120", "120", "120", "150", "150", "150", "150", "150", "150", "150", "150", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200", "200"})
        Me.T_flange_breadth.Location = New System.Drawing.Point(216, 268)
        Me.T_flange_breadth.Name = "T_flange_breadth"
        Me.T_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.T_flange_breadth.TabIndex = 24
        Me.T_flange_breadth.Visible = False
        '
        'Label_title03
        '
        Me.Label_title03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title03.Location = New System.Drawing.Point(11, 18)
        Me.Label_title03.Name = "Label_title03"
        Me.Label_title03.Size = New System.Drawing.Size(197, 20)
        Me.Label_title03.TabIndex = 1
        Me.Label_title03.Text = "שם החיזוק לפי התקן"
        '
        'T_centroid
        '
        Me.T_centroid.ItemHeight = 16
        Me.T_centroid.Items.AddRange(New Object() {"19.6", "21.6", "24.2", "25.6", "28.2", "29.6", "30.7", "31.6", "31", "33.8", "35.1", "36.4", "37.5", "37.9", "40.5", "40.7", "42.1", "43.4", "42.8", "44.3", "45.7", "45.7", "48.7", "48.5", "51.7", "51.3", "53.1", "54.7", "54.5", "56.1", "57.2", "58.9"})
        Me.T_centroid.Location = New System.Drawing.Point(284, 248)
        Me.T_centroid.Name = "T_centroid"
        Me.T_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_centroid.Size = New System.Drawing.Size(64, 20)
        Me.T_centroid.TabIndex = 10
        Me.T_centroid.Visible = False
        '
        'T_a
        '
        Me.T_a.ItemHeight = 16
        Me.T_a.Items.AddRange(New Object() {"51", "57", "66", "69", "78", "81", "87", "93", "84", "90", "97.5", "105", "112.5", "103.5", "118.5", "109.5", "117", "124.5", "122", "132", "142", "128", "148", "134", "154", "140", "150", "160", "172", "182", "179", "189"})
        Me.T_a.Location = New System.Drawing.Point(284, 220)
        Me.T_a.Name = "T_a"
        Me.T_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_a.Size = New System.Drawing.Size(64, 20)
        Me.T_a.TabIndex = 9
        Me.T_a.Visible = False
        '
        'T_i
        '
        Me.T_i.ItemHeight = 16
        Me.T_i.Items.AddRange(New Object() {"5329", "6995", "9523", "11387", "14750", "17250", "18630", "19900", "20010", "26300", "28420", "30590", "32590", "36420", "41710", "45700", "49110", "52260", "50440", "54120", "57450", "62190", "70810", "75510", "85940", "90480", "96990", "102920", "127070", "134890", "148920", "158020"})
        Me.T_i.Location = New System.Drawing.Point(284, 196)
        Me.T_i.Name = "T_i"
        Me.T_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_i.Size = New System.Drawing.Size(64, 20)
        Me.T_i.TabIndex = 8
        Me.T_i.Visible = False
        '
        'ListBox5
        '
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Items.AddRange(New Object() {"5", "5", "5", "5", "5", "5", "5", "5", "5", "5", "5", "5"})
        Me.ListBox5.Location = New System.Drawing.Point(284, 272)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox5.Size = New System.Drawing.Size(64, 20)
        Me.ListBox5.TabIndex = 7
        Me.ListBox5.Visible = False
        '
        'T_flange_thickness
        '
        Me.T_flange_thickness.ItemHeight = 16
        Me.T_flange_thickness.Items.AddRange(New Object() {"15", "15", "20", "20", "25", "25", "30", "35", "25", "25", "25", "30", "35", "25", "35", "25", "30", "35", "25", "30", "35", "25", "35", "25", "35", "25", "30", "35", "30", "35", "30", "35"})
        Me.T_flange_thickness.Location = New System.Drawing.Point(216, 244)
        Me.T_flange_thickness.Name = "T_flange_thickness"
        Me.T_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.T_flange_thickness.TabIndex = 6
        Me.T_flange_thickness.Visible = False
        '
        'T_web_thickness
        '
        Me.T_web_thickness.ItemHeight = 16
        Me.T_web_thickness.Items.AddRange(New Object() {"12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "14", "14", "14", "14"})
        Me.T_web_thickness.Location = New System.Drawing.Point(216, 220)
        Me.T_web_thickness.Name = "T_web_thickness"
        Me.T_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.T_web_thickness.TabIndex = 5
        Me.T_web_thickness.Visible = False
        '
        'T_web_depth
        '
        Me.T_web_depth.ItemHeight = 16
        Me.T_web_depth.Items.AddRange(New Object() {"300", "325", "350", "375", "400", "425", "425", "425", "450", "500", "500", "500", "500", "550", "550", "600", "600", "600", "600", "600", "600", "650", "650", "700", "700", "750", "750", "750", "800", "800", "850", "850"})
        Me.T_web_depth.Location = New System.Drawing.Point(216, 196)
        Me.T_web_depth.Name = "T_web_depth"
        Me.T_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.T_web_depth.TabIndex = 3
        Me.T_web_depth.Visible = False
        '
        'IP_T_groupbox
        '
        Me.IP_T_groupbox.Controls.Add(Me.T_web_thickness_label)
        Me.IP_T_groupbox.Controls.Add(Me.T_flange_thickness_label)
        Me.IP_T_groupbox.Controls.Add(Me.T_flange_breadth_label)
        Me.IP_T_groupbox.Controls.Add(Me.T_web_depth_label)
        Me.IP_T_groupbox.Controls.Add(Me.PictureBox9)
        Me.IP_T_groupbox.Location = New System.Drawing.Point(580, 40)
        Me.IP_T_groupbox.Name = "IP_T_groupbox"
        Me.IP_T_groupbox.Size = New System.Drawing.Size(276, 280)
        Me.IP_T_groupbox.TabIndex = 22
        Me.IP_T_groupbox.TabStop = False
        Me.IP_T_groupbox.Text = "Profile: Inexa Profil (T section)"
        '
        'T_web_thickness_label
        '
        Me.T_web_thickness_label.AutoEllipsis = True
        Me.T_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.T_web_thickness_label.Location = New System.Drawing.Point(144, 232)
        Me.T_web_thickness_label.Name = "T_web_thickness_label"
        Me.T_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_web_thickness_label.Size = New System.Drawing.Size(72, 19)
        Me.T_web_thickness_label.TabIndex = 12
        '
        'T_flange_thickness_label
        '
        Me.T_flange_thickness_label.AutoEllipsis = True
        Me.T_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.T_flange_thickness_label.Location = New System.Drawing.Point(4, 80)
        Me.T_flange_thickness_label.Name = "T_flange_thickness_label"
        Me.T_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_flange_thickness_label.Size = New System.Drawing.Size(77, 20)
        Me.T_flange_thickness_label.TabIndex = 14
        Me.T_flange_thickness_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'T_flange_breadth_label
        '
        Me.T_flange_breadth_label.AutoEllipsis = True
        Me.T_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.T_flange_breadth_label.Location = New System.Drawing.Point(156, 40)
        Me.T_flange_breadth_label.Name = "T_flange_breadth_label"
        Me.T_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_flange_breadth_label.Size = New System.Drawing.Size(64, 20)
        Me.T_flange_breadth_label.TabIndex = 13
        '
        'T_web_depth_label
        '
        Me.T_web_depth_label.AutoEllipsis = True
        Me.T_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.T_web_depth_label.Location = New System.Drawing.Point(84, 136)
        Me.T_web_depth_label.Name = "T_web_depth_label"
        Me.T_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.T_web_depth_label.Size = New System.Drawing.Size(67, 21)
        Me.T_web_depth_label.TabIndex = 11
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(84, 60)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(176, 164)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'IP_T_names
        '
        Me.IP_T_names.ItemHeight = 16
        Me.IP_T_names.Items.AddRange(New Object() {"315x100x12x15", "340x120x12x15", "370x120x12x20", "395x120x12x20", "425x120x12x25", "450x120x12x25", "455x120x12x30", "460x120x12x35", "475x120x12x25", "525x120x12x25", "525x150x12x25", "530x150x12x30", "535x150x12x35", "575x150x12x25", "585x150x12x35", "625x150x12x25", "630x150x12x30", "635x150x12x35", "625x200x12x25", "630x200x12x30", "635x200x12x35", "675x200x12x25", "685x200x12x35", "725x200x12x25", "735x200x12x35", "775x200x12x25", "780x200x12x30", "785x200x12x35", "830x200x14x30", "835x200x14x35", "880x200x14x30", "885x200x14x35"})
        Me.IP_T_names.Location = New System.Drawing.Point(15, 46)
        Me.IP_T_names.Name = "IP_T_names"
        Me.IP_T_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_T_names.Size = New System.Drawing.Size(189, 276)
        Me.IP_T_names.TabIndex = 0
        '
        'FDA_LIU
        '
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_flange_breadth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_centroid)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_A)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_i)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_web_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_web_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_flange_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_profile_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_flange_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_centroid)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_A)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_i)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_web_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_web_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_flange_breadth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_profile_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_nordic_names)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_flange_breadth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_centroid)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_A)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_i)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_web_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_web_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_flange_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_profile_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_Korean_names)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_flange_breadth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_centroid)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_A)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_i)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_web_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_web_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_flange_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_profile_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_ISO_names)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_flange_breadth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_centroid)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_A)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_i)
        Me.FDA_LIU.Controls.Add(Me.box07)
        Me.FDA_LIU.Controls.Add(Me.Label_title07)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_names)
        Me.FDA_LIU.Controls.Add(Me.ListBox6)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_web_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_web_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_flange_thickness)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_euro_profile_depth)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_japanese_names)
        Me.FDA_LIU.Controls.Add(Me.FDA_LIA_PIC)
        Me.FDA_LIU.Location = New System.Drawing.Point(6, 12)
        Me.FDA_LIU.Name = "FDA_LIU"
        Me.FDA_LIU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIU.Size = New System.Drawing.Size(868, 356)
        Me.FDA_LIU.TabIndex = 14
        Me.FDA_LIU.TabStop = False
        Me.FDA_LIU.Text = "Standard LIA stiffeners (FDA)"
        Me.FDA_LIU.Visible = False
        '
        'FDA_LIA_japanese_flange_breadth
        '
        Me.FDA_LIA_japanese_flange_breadth.ItemHeight = 16
        Me.FDA_LIA_japanese_flange_breadth.Items.AddRange(New Object() {"90", "90", "90", "90", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "125", "150", "150", "150", "150"})
        Me.FDA_LIA_japanese_flange_breadth.Location = New System.Drawing.Point(472, 288)
        Me.FDA_LIA_japanese_flange_breadth.Name = "FDA_LIA_japanese_flange_breadth"
        Me.FDA_LIA_japanese_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_flange_breadth.TabIndex = 65
        Me.FDA_LIA_japanese_flange_breadth.Visible = False
        '
        'FDA_LIA_japanese_centroid
        '
        Me.FDA_LIA_japanese_centroid.ItemHeight = 16
        Me.FDA_LIA_japanese_centroid.Items.AddRange(New Object() {"13.885153", "13.594479", "16.62013", "16.310811", "16.184305", "15.937288", "19.246729", "18.932691", "18.808952", "18.555836", "22.197268", "21.872963", "24.519149", "24.739098", "24.420721", "28.613716", "28.730352", "32.288766", "35.570341", "38.556917"})
        Me.FDA_LIA_japanese_centroid.Location = New System.Drawing.Point(504, 244)
        Me.FDA_LIA_japanese_centroid.Name = "FDA_LIA_japanese_centroid"
        Me.FDA_LIA_japanese_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_centroid.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_centroid.TabIndex = 64
        Me.FDA_LIA_japanese_centroid.Visible = False
        '
        'FDA_LIA_japanese_A
        '
        Me.FDA_LIA_japanese_A.ItemHeight = 16
        Me.FDA_LIA_japanese_A.Items.AddRange(New Object() {"27.48", "29.34", "34.65", "37", "40.14", "42.48", "42.8", "45.64", "49.26", "52.09", "53.63", "56.96", "60.16", "63.84", "67.66", "72.18", "72.525", "82.43", "94.98", "106.625"})
        Me.FDA_LIA_japanese_A.Location = New System.Drawing.Point(504, 216)
        Me.FDA_LIA_japanese_A.Name = "FDA_LIA_japanese_A"
        Me.FDA_LIA_japanese_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_A.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_A.TabIndex = 63
        Me.FDA_LIA_japanese_A.Visible = False
        '
        'FDA_LIA_japanese_i
        '
        Me.FDA_LIA_japanese_i.ItemHeight = 16
        Me.FDA_LIA_japanese_i.Items.AddRange(New Object() {"113.319142", "1203.567906", "2263.412459", "2423.759009", "2620.413312", "2771.650536", "4061.837209", "4320.555359", "4643.473852", "4890.440634", "6944.918566", "7349.116230", "10127.666474", "10749.081612", "11328.221882", "15572.240021", "15749.357939", "22086.305564", "30736.544651", "41028.970003"})
        Me.FDA_LIA_japanese_i.Location = New System.Drawing.Point(504, 192)
        Me.FDA_LIA_japanese_i.Name = "FDA_LIA_japanese_i"
        Me.FDA_LIA_japanese_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_i.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_i.TabIndex = 62
        Me.FDA_LIA_japanese_i.Visible = False
        '
        'FDA_LIA_japanese_web_depth
        '
        Me.FDA_LIA_japanese_web_depth.ItemHeight = 16
        Me.FDA_LIA_japanese_web_depth.Items.AddRange(New Object() {"186", "186", "235", "235", "234", "234", "284", "284", "283", "283", "333", "333", "384", "382", "382", "432", "435", "482", "529", "577"})
        Me.FDA_LIA_japanese_web_depth.Location = New System.Drawing.Point(472, 240)
        Me.FDA_LIA_japanese_web_depth.Name = "FDA_LIA_japanese_web_depth"
        Me.FDA_LIA_japanese_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_web_depth.TabIndex = 60
        Me.FDA_LIA_japanese_web_depth.Visible = False
        '
        'FDA_LIA_japanese_web_thickness
        '
        Me.FDA_LIA_japanese_web_thickness.ItemHeight = 16
        Me.FDA_LIA_japanese_web_thickness.Items.AddRange(New Object() {"8", "9", "9", "10", "11", "12", "10", "11", "12", "13", "11", "12", "11.5", "12", "13", "11.5", "11.5", "11.5", "12", "12.5"})
        Me.FDA_LIA_japanese_web_thickness.Location = New System.Drawing.Point(472, 216)
        Me.FDA_LIA_japanese_web_thickness.Name = "FDA_LIA_japanese_web_thickness"
        Me.FDA_LIA_japanese_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_web_thickness.TabIndex = 59
        Me.FDA_LIA_japanese_web_thickness.Visible = False
        '
        'FDA_LIA_japanese_flange_thickness
        '
        Me.FDA_LIA_japanese_flange_thickness.ItemHeight = 16
        Me.FDA_LIA_japanese_flange_thickness.Items.AddRange(New Object() {"14", "14", "15", "15", "16", "16", "16", "16", "17", "17", "17", "17", "16", "18", "18", "18", "15", "18", "21", "23"})
        Me.FDA_LIA_japanese_flange_thickness.Location = New System.Drawing.Point(472, 264)
        Me.FDA_LIA_japanese_flange_thickness.Name = "FDA_LIA_japanese_flange_thickness"
        Me.FDA_LIA_japanese_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_flange_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_flange_thickness.TabIndex = 61
        Me.FDA_LIA_japanese_flange_thickness.Visible = False
        '
        'FDA_LIA_japanese_profile_depth
        '
        Me.FDA_LIA_japanese_profile_depth.ItemHeight = 16
        Me.FDA_LIA_japanese_profile_depth.Items.AddRange(New Object() {"200", "200", "250", "250", "250", "250", "300", "300", "300", "300", "350", "350", "400", "400", "400", "450", "450", "500", "550", "600"})
        Me.FDA_LIA_japanese_profile_depth.Location = New System.Drawing.Point(472, 192)
        Me.FDA_LIA_japanese_profile_depth.Name = "FDA_LIA_japanese_profile_depth"
        Me.FDA_LIA_japanese_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_japanese_profile_depth.TabIndex = 58
        Me.FDA_LIA_japanese_profile_depth.Visible = False
        '
        'FDA_LIA_nordic_flange_thickness
        '
        Me.FDA_LIA_nordic_flange_thickness.ItemHeight = 16
        Me.FDA_LIA_nordic_flange_thickness.Items.AddRange(New Object() {"12", "14", "15", "12", "14", "15", "12", "15", "14", "15", "15", "16", "14", "15", "16", "18", "18", "23", "25", "24", "26", "25", "27", "28", "30", "30", "35"})
        Me.FDA_LIA_nordic_flange_thickness.Location = New System.Drawing.Point(408, 288)
        Me.FDA_LIA_nordic_flange_thickness.Name = "FDA_LIA_nordic_flange_thickness"
        Me.FDA_LIA_nordic_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_flange_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_flange_thickness.TabIndex = 56
        Me.FDA_LIA_nordic_flange_thickness.Visible = False
        '
        'FDA_LIA_nordic_centroid
        '
        Me.FDA_LIA_nordic_centroid.ItemHeight = 16
        Me.FDA_LIA_nordic_centroid.Items.AddRange(New Object() {"13.296104", "13.221569", "13.132099", "14.704054", "14.62855", "14.533865", "16.089944", "16.170432", "17.699197", "17.593541", "19.258347", "19.132182", "21.07017", "20.952004", "22.891266", "22.923185", "24.704532", "26.629579", "26.554878", "28.219258", "28.127613", "29.807845", "29.698813", "31.727683", "31.581514", "33.494448", "33.271475"})
        Me.FDA_LIA_nordic_centroid.Location = New System.Drawing.Point(440, 244)
        Me.FDA_LIA_nordic_centroid.Name = "FDA_LIA_nordic_centroid"
        Me.FDA_LIA_nordic_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_centroid.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_centroid.TabIndex = 55
        Me.FDA_LIA_nordic_centroid.Visible = False
        '
        'FDA_LIA_nordic_A
        '
        Me.FDA_LIA_nordic_A.ItemHeight = 16
        Me.FDA_LIA_nordic_A.Items.AddRange(New Object() {"27.72", "32.13", "34.775", "29.97", "34.755", "37.65", "32.22", "38.175", "41.405", "44.9", "44.925", "48.66", "49.455", "53.65", "54.27", "59.78", "59.085", "70.955", "76.875", "74.915", "81.075", "78.875", "85.275", "85.005", "91.625", "90.05", "104.775"})
        Me.FDA_LIA_nordic_A.Location = New System.Drawing.Point(440, 216)
        Me.FDA_LIA_nordic_A.Name = "FDA_LIA_nordic_A"
        Me.FDA_LIA_nordic_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_A.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_A.TabIndex = 54
        Me.FDA_LIA_nordic_A.Visible = False
        '
        'FDA_LIA_nordic_i
        '
        Me.FDA_LIA_nordic_i.ItemHeight = 16
        Me.FDA_LIA_nordic_i.Items.AddRange(New Object() {"1158.867179", "1330.990253", "1435.228586", "1600.373207", "1840.580021", "1985.994323", "2134.248932", "2591.522375", "3309.90459", "3575.698794", "4276.482807", "4614.877002", "5564.007843", "6016.759743", "7064.05476", "7737.628332", "8804.684837", "11892.84194", "12825.86223", "14198.68623", "15301.35993", "16783.28556", "18074.15763", "20042.39894", "21534.08911", "23481.70139", "27081.597"})
        Me.FDA_LIA_nordic_i.Location = New System.Drawing.Point(440, 192)
        Me.FDA_LIA_nordic_i.Name = "FDA_LIA_nordic_i"
        Me.FDA_LIA_nordic_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_i.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_i.TabIndex = 53
        Me.FDA_LIA_nordic_i.Visible = False
        '
        'FDA_LIA_nordic_web_depth
        '
        Me.FDA_LIA_nordic_web_depth.ItemHeight = 16
        Me.FDA_LIA_nordic_web_depth.Items.AddRange(New Object() {"188", "186", "185", "213", "211", "210", "238", "235", "261", "260", "285", "284", "311", "310", "334", "332", "357", "377", "375", "401", "399", "425", "423", "447", "445", "470", "465"})
        Me.FDA_LIA_nordic_web_depth.Location = New System.Drawing.Point(408, 240)
        Me.FDA_LIA_nordic_web_depth.Name = "FDA_LIA_nordic_web_depth"
        Me.FDA_LIA_nordic_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_web_depth.TabIndex = 51
        Me.FDA_LIA_nordic_web_depth.Visible = False
        '
        'FDA_LIA_nordic_web_thickness
        '
        Me.FDA_LIA_nordic_web_thickness.ItemHeight = 16
        Me.FDA_LIA_nordic_web_thickness.Items.AddRange(New Object() {"9", "10.5", "11.5", "9", "10.5", "11.5", "9", "10.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "12.5", "11.5", "12.5", "11.5", "12.5", "11.5", "12.5", "11.5", "13.5"})
        Me.FDA_LIA_nordic_web_thickness.Location = New System.Drawing.Point(408, 216)
        Me.FDA_LIA_nordic_web_thickness.Name = "FDA_LIA_nordic_web_thickness"
        Me.FDA_LIA_nordic_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_web_thickness.TabIndex = 50
        Me.FDA_LIA_nordic_web_thickness.Visible = False
        '
        'FDA_LIA_nordic_flange_breadth
        '
        Me.FDA_LIA_nordic_flange_breadth.ItemHeight = 16
        Me.FDA_LIA_nordic_flange_breadth.Items.AddRange(New Object() {"90", "90", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120"})
        Me.FDA_LIA_nordic_flange_breadth.Location = New System.Drawing.Point(408, 264)
        Me.FDA_LIA_nordic_flange_breadth.Name = "FDA_LIA_nordic_flange_breadth"
        Me.FDA_LIA_nordic_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_flange_breadth.TabIndex = 52
        Me.FDA_LIA_nordic_flange_breadth.Visible = False
        '
        'FDA_LIA_nordic_profile_depth
        '
        Me.FDA_LIA_nordic_profile_depth.ItemHeight = 16
        Me.FDA_LIA_nordic_profile_depth.Items.AddRange(New Object() {"200", "200", "200", "225", "225", "225", "250", "250", "275", "275", "300", "300", "325", "325", "350", "350", "375", "400", "400", "425", "425", "450", "450", "475", "475", "500", "500"})
        Me.FDA_LIA_nordic_profile_depth.Location = New System.Drawing.Point(408, 192)
        Me.FDA_LIA_nordic_profile_depth.Name = "FDA_LIA_nordic_profile_depth"
        Me.FDA_LIA_nordic_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_nordic_profile_depth.TabIndex = 49
        Me.FDA_LIA_nordic_profile_depth.Visible = False
        '
        'FDA_LIA_nordic_names
        '
        Me.FDA_LIA_nordic_names.ItemHeight = 16
        Me.FDA_LIA_nordic_names.Items.AddRange(New Object() {"200.0 x 90.0 x 9.0/12.0 IA", "200.0 x 90.0 x 10.5/14.0 IA", "200.0 x 90.0 x 11.5/15.0 IA", "225.0 x 90.0 x 9.0/12.0 IA", "225.0 x 90.0 x 10.5/14.0 IA", "225.0 x 90.0 x 11.5/15.0 IA", "250.0 x 90.0 x 9.0/12.0 IA", "250.0 x 90.0 x 10.5/15.0 IA", "275.0 x 100.0 x 10.5/14.0 IA", "275.0 x 100.0 x 11.5/15.0 IA", "300.0 x 100.0 x 10.5/15.0 IA", "300.0 x 100.0 x 11.5/16.0 IA", "325.0 x 120.0 x 10.5/14.0 IA", "325.0 x 120.0 x 11.5/15.0 IA", "350.0 x 120.0 x 10.5/16.0 IA", "350.0 x 120.0 x 11.5/18.0 IA", "375.0 x 120.0 x 10.5/18.0 IA", "400.0 x 120.0 x 11.5/23.0 IA", "400.0 x 120.0 x 12.5/25.0 IA", "425.0 x 120.0 x 11.5/24.0 IA", "425.0 x 120.0 x 12.5/26.0 IA", "450.0 x 120.0 x 11.5/25.0 IA", "450.0 x 120.0 x 12.5/27.0 IA", "475.0 x 120.0 x 11.5/28.0 IA", "475.0 x 120.0 x 12.5/30.0 IA", "500.0 x 120.0 x 11.5/30.0 IA", "500.0 x 120.0 x 13.5/35.0 IA"})
        Me.FDA_LIA_nordic_names.Location = New System.Drawing.Point(16, 46)
        Me.FDA_LIA_nordic_names.Name = "FDA_LIA_nordic_names"
        Me.FDA_LIA_nordic_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_nordic_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_LIA_nordic_names.TabIndex = 48
        '
        'FDA_LIA_Korean_flange_breadth
        '
        Me.FDA_LIA_Korean_flange_breadth.ItemHeight = 16
        Me.FDA_LIA_Korean_flange_breadth.Items.AddRange(New Object() {"90", "90", "90", "90", "90", "100", "100"})
        Me.FDA_LIA_Korean_flange_breadth.Location = New System.Drawing.Point(344, 288)
        Me.FDA_LIA_Korean_flange_breadth.Name = "FDA_LIA_Korean_flange_breadth"
        Me.FDA_LIA_Korean_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_flange_breadth.TabIndex = 47
        Me.FDA_LIA_Korean_flange_breadth.Visible = False
        '
        'FDA_LIA_Korean_centroid
        '
        Me.FDA_LIA_Korean_centroid.ItemHeight = 16
        Me.FDA_LIA_Korean_centroid.Items.AddRange(New Object() {"13.594479", "16.310811", "15.937288", "18.932691", "18.555836", "21.872963", "24.420721"})
        Me.FDA_LIA_Korean_centroid.Location = New System.Drawing.Point(376, 244)
        Me.FDA_LIA_Korean_centroid.Name = "FDA_LIA_Korean_centroid"
        Me.FDA_LIA_Korean_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_centroid.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_centroid.TabIndex = 46
        Me.FDA_LIA_Korean_centroid.Visible = False
        '
        'FDA_LIA_Korean_A
        '
        Me.FDA_LIA_Korean_A.ItemHeight = 16
        Me.FDA_LIA_Korean_A.Items.AddRange(New Object() {"29.34", "37", "42.48", "45.64", "52.09", "56.96", "67.66"})
        Me.FDA_LIA_Korean_A.Location = New System.Drawing.Point(376, 216)
        Me.FDA_LIA_Korean_A.Name = "FDA_LIA_Korean_A"
        Me.FDA_LIA_Korean_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_A.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_A.TabIndex = 45
        Me.FDA_LIA_Korean_A.Visible = False
        '
        'FDA_LIA_Korean_i
        '
        Me.FDA_LIA_Korean_i.ItemHeight = 16
        Me.FDA_LIA_Korean_i.Items.AddRange(New Object() {"1203.457906", "2423.759009", "2771.650536", "4320.555359", "4890.440634", "7349.11623", "11328.22188"})
        Me.FDA_LIA_Korean_i.Location = New System.Drawing.Point(376, 192)
        Me.FDA_LIA_Korean_i.Name = "FDA_LIA_Korean_i"
        Me.FDA_LIA_Korean_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_i.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_i.TabIndex = 44
        Me.FDA_LIA_Korean_i.Visible = False
        '
        'FDA_LIA_Korean_web_depth
        '
        Me.FDA_LIA_Korean_web_depth.ItemHeight = 16
        Me.FDA_LIA_Korean_web_depth.Items.AddRange(New Object() {"186", "235", "234", "284", "283", "333", "382"})
        Me.FDA_LIA_Korean_web_depth.Location = New System.Drawing.Point(344, 240)
        Me.FDA_LIA_Korean_web_depth.Name = "FDA_LIA_Korean_web_depth"
        Me.FDA_LIA_Korean_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_web_depth.TabIndex = 42
        Me.FDA_LIA_Korean_web_depth.Visible = False
        '
        'FDA_LIA_Korean_web_thickness
        '
        Me.FDA_LIA_Korean_web_thickness.ItemHeight = 16
        Me.FDA_LIA_Korean_web_thickness.Items.AddRange(New Object() {"9", "10", "12", "11", "13", "12", "13"})
        Me.FDA_LIA_Korean_web_thickness.Location = New System.Drawing.Point(344, 216)
        Me.FDA_LIA_Korean_web_thickness.Name = "FDA_LIA_Korean_web_thickness"
        Me.FDA_LIA_Korean_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_web_thickness.TabIndex = 41
        Me.FDA_LIA_Korean_web_thickness.Visible = False
        '
        'FDA_LIA_Korean_flange_thickness
        '
        Me.FDA_LIA_Korean_flange_thickness.ItemHeight = 16
        Me.FDA_LIA_Korean_flange_thickness.Items.AddRange(New Object() {"14", "15", "16", "16", "17", "17", "18"})
        Me.FDA_LIA_Korean_flange_thickness.Location = New System.Drawing.Point(344, 264)
        Me.FDA_LIA_Korean_flange_thickness.Name = "FDA_LIA_Korean_flange_thickness"
        Me.FDA_LIA_Korean_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_flange_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_flange_thickness.TabIndex = 43
        Me.FDA_LIA_Korean_flange_thickness.Visible = False
        '
        'FDA_LIA_Korean_profile_depth
        '
        Me.FDA_LIA_Korean_profile_depth.ItemHeight = 16
        Me.FDA_LIA_Korean_profile_depth.Items.AddRange(New Object() {"200", "250", "250", "300", "300", "350", "400"})
        Me.FDA_LIA_Korean_profile_depth.Location = New System.Drawing.Point(344, 192)
        Me.FDA_LIA_Korean_profile_depth.Name = "FDA_LIA_Korean_profile_depth"
        Me.FDA_LIA_Korean_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_Korean_profile_depth.TabIndex = 40
        Me.FDA_LIA_Korean_profile_depth.Visible = False
        '
        'FDA_LIA_Korean_names
        '
        Me.FDA_LIA_Korean_names.ItemHeight = 16
        Me.FDA_LIA_Korean_names.Items.AddRange(New Object() {"200.0 x 90.0 x 9.0/14.0 IA", "250.0 x 90.0 x 10.0/15.0 IA", "250.0 x 90.0 x 12.0/16.0 IA", "300.0 x 90.0 x 11.0/16.0 IA", "300.0 x 90.0 x 13.0/17.0 IA", "350.0 x 100.0 x 12.0/17.0 IA", "400.0 x 100.0 x 13.0/18.0 IA"})
        Me.FDA_LIA_Korean_names.Location = New System.Drawing.Point(16, 46)
        Me.FDA_LIA_Korean_names.Name = "FDA_LIA_Korean_names"
        Me.FDA_LIA_Korean_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_Korean_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_LIA_Korean_names.TabIndex = 39
        '
        'FDA_LIA_ISO_flange_breadth
        '
        Me.FDA_LIA_ISO_flange_breadth.ItemHeight = 16
        Me.FDA_LIA_ISO_flange_breadth.Items.AddRange(New Object() {"90", "90", "90", "90", "90", "100", "100", "100", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120"})
        Me.FDA_LIA_ISO_flange_breadth.Location = New System.Drawing.Point(284, 288)
        Me.FDA_LIA_ISO_flange_breadth.Name = "FDA_LIA_ISO_flange_breadth"
        Me.FDA_LIA_ISO_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_flange_breadth.TabIndex = 38
        Me.FDA_LIA_ISO_flange_breadth.Visible = False
        '
        'FDA_LIA_ISO_centroid
        '
        Me.FDA_LIA_ISO_centroid.ItemHeight = 16
        Me.FDA_LIA_ISO_centroid.Items.AddRange(New Object() {"13.296104", "14.704054", "16.277793", "16.170432", "16.057298", "17.699197", "19.258347", "19.132182", "21.07017", "20.952004", "22.891266", "22.923185", "24.704532", "24.691766", "26.629579", "28.219258", "29.807845", "31.737683", "31.581514", "33.454619", "33.271475"})
        Me.FDA_LIA_ISO_centroid.Location = New System.Drawing.Point(316, 244)
        Me.FDA_LIA_ISO_centroid.Name = "FDA_LIA_ISO_centroid"
        Me.FDA_LIA_ISO_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_centroid.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_centroid.TabIndex = 37
        Me.FDA_LIA_ISO_centroid.Visible = False
        '
        'FDA_LIA_ISO_A
        '
        Me.FDA_LIA_ISO_A.ItemHeight = 16
        Me.FDA_LIA_ISO_A.Items.AddRange(New Object() {"27.72", "29.97", "33.03", "38.175", "41.31", "41.405", "44.925", "48.66", "49.455", "53.65", "54.27", "59.78", "59.085", "64.825", "70.955", "74.915", "78.875", "85.005", "91.625", "97.975", "104.775"})
        Me.FDA_LIA_ISO_A.Location = New System.Drawing.Point(316, 216)
        Me.FDA_LIA_ISO_A.Name = "FDA_LIA_ISO_A"
        Me.FDA_LIA_ISO_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_A.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_A.TabIndex = 36
        Me.FDA_LIA_ISO_A.Visible = False
        '
        'FDA_LIA_ISO_i
        '
        Me.FDA_LIA_ISO_i.ItemHeight = 16
        Me.FDA_LIA_ISO_i.Items.AddRange(New Object() {"1158.867179", "1600.373207", "2180.612011", "2501.522375", "2696.661575", "3309.90459", "4276.482807", "4614.877002", "5564.007843", "6016.759743", "7064.05476", "7737.628332", "8804.684837", "9609.180689", "11892.84194", "14198.68623", "16783.28556", "20042.39894", "21534.08911", "25391.48581", "27081.597"})
        Me.FDA_LIA_ISO_i.Location = New System.Drawing.Point(316, 192)
        Me.FDA_LIA_ISO_i.Name = "FDA_LIA_ISO_i"
        Me.FDA_LIA_ISO_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_i.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_i.TabIndex = 35
        Me.FDA_LIA_ISO_i.Visible = False
        '
        'FDA_LIA_ISO_web_depth
        '
        Me.FDA_LIA_ISO_web_depth.ItemHeight = 16
        Me.FDA_LIA_ISO_web_depth.Items.AddRange(New Object() {"188", "213", "237", "235", "234", "261", "285", "284", "311", "310", "334", "332", "357", "355", "377", "401", "425", "447", "445", "467", "465"})
        Me.FDA_LIA_ISO_web_depth.Location = New System.Drawing.Point(284, 240)
        Me.FDA_LIA_ISO_web_depth.Name = "FDA_LIA_ISO_web_depth"
        Me.FDA_LIA_ISO_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_web_depth.TabIndex = 33
        Me.FDA_LIA_ISO_web_depth.Visible = False
        '
        'FDA_LIA_ISO_web_thickness
        '
        Me.FDA_LIA_ISO_web_thickness.ItemHeight = 16
        Me.FDA_LIA_ISO_web_thickness.Items.AddRange(New Object() {"9", "9", "9", "10.5", "11.5", "10.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "10.5", "11.5", "11.5", "11.5", "11.5", "11.5", "12.5", "12.5", "13.5"})
        Me.FDA_LIA_ISO_web_thickness.Location = New System.Drawing.Point(284, 216)
        Me.FDA_LIA_ISO_web_thickness.Name = "FDA_LIA_ISO_web_thickness"
        Me.FDA_LIA_ISO_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_web_thickness.TabIndex = 32
        Me.FDA_LIA_ISO_web_thickness.Visible = False
        '
        'FDA_LIA_ISO_flange_thickness
        '
        Me.FDA_LIA_ISO_flange_thickness.ItemHeight = 16
        Me.FDA_LIA_ISO_flange_thickness.Items.AddRange(New Object() {"12", "12", "13", "15", "16", "14", "15", "16", "14", "15", "16", "18", "18", "20", "23", "24", "25", "28", "30", "33", "35"})
        Me.FDA_LIA_ISO_flange_thickness.Location = New System.Drawing.Point(284, 264)
        Me.FDA_LIA_ISO_flange_thickness.Name = "FDA_LIA_ISO_flange_thickness"
        Me.FDA_LIA_ISO_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_flange_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_flange_thickness.TabIndex = 34
        Me.FDA_LIA_ISO_flange_thickness.Visible = False
        '
        'FDA_LIA_ISO_profile_depth
        '
        Me.FDA_LIA_ISO_profile_depth.ItemHeight = 16
        Me.FDA_LIA_ISO_profile_depth.Items.AddRange(New Object() {"200", "225", "250", "250", "250", "275", "300", "300", "325", "325", "350", "350", "375", "375", "400", "425", "450", "475", "475", "500", "500"})
        Me.FDA_LIA_ISO_profile_depth.Location = New System.Drawing.Point(284, 192)
        Me.FDA_LIA_ISO_profile_depth.Name = "FDA_LIA_ISO_profile_depth"
        Me.FDA_LIA_ISO_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_ISO_profile_depth.TabIndex = 31
        Me.FDA_LIA_ISO_profile_depth.Visible = False
        '
        'FDA_LIA_ISO_names
        '
        Me.FDA_LIA_ISO_names.ItemHeight = 16
        Me.FDA_LIA_ISO_names.Items.AddRange(New Object() {"200.0 x 90.0 x 9.0/12.0 IA", "225.0 x 90.0 x 9.0/12.0 IA", "250.0 x 90.0 x 9.0/13.0 IA", "250.0 x 90.0 x 10.5/15.0 IA", "250.0 x 90.0 x 11.5/16.0 IA", "275.0 x 100.0 x 10.5/14.0 IA", "300.0 x 100.0 x 10.5/15.0 IA", "300.0 x 100.0 x 11.5/16.0 IA", "325.0 x 120.0 x 10.5/14.0 IA", "325.0 x 120.0 x 11.5/15.0 IA", "350.0 x 120.0 x 10.5/16.0 IA", "350.0 x 120.0 x 11.5/18.0 IA", "375.0 x 120.0 x 10.5/18.0 IA", "375.0 x 120.0 x 11.5/20.0 IA", "400.0 x 120.0 x 11.5/23.0 IA", "425.0 x 120.0 x 11.5/24.0 IA", "450.0 x 120.0 x 11.5/25.0 IA", "475.0 x 120.0 x 11.5/28.0 IA", "475.0 x 120.0 x 12.5/30.0 IA", "500.0 x 120.0 x 12.5/33.0 IA", "500.0 x 120.0 x 13.5/35.0 IA"})
        Me.FDA_LIA_ISO_names.Location = New System.Drawing.Point(16, 46)
        Me.FDA_LIA_ISO_names.Name = "FDA_LIA_ISO_names"
        Me.FDA_LIA_ISO_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_ISO_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_LIA_ISO_names.TabIndex = 30
        '
        'FDA_LIA_euro_flange_breadth
        '
        Me.FDA_LIA_euro_flange_breadth.ItemHeight = 16
        Me.FDA_LIA_euro_flange_breadth.Items.AddRange(New Object() {"100", "100", "100", "100", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120", "120"})
        Me.FDA_LIA_euro_flange_breadth.Location = New System.Drawing.Point(220, 288)
        Me.FDA_LIA_euro_flange_breadth.Name = "FDA_LIA_euro_flange_breadth"
        Me.FDA_LIA_euro_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_flange_breadth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_flange_breadth.TabIndex = 29
        Me.FDA_LIA_euro_flange_breadth.Visible = False
        '
        'FDA_LIA_euro_centroid
        '
        Me.FDA_LIA_euro_centroid.ItemHeight = 16
        Me.FDA_LIA_euro_centroid.Items.AddRange(New Object() {"19.4000802", "19.258347", "19.132182", "19.018735", "23.072127", "22.891266", "22.923185", "22.767374", "26.937322", "26.629579", "26.554878", "30.18357", "29.807845", "29.689913", "33.343619", "33.271475"})
        Me.FDA_LIA_euro_centroid.Location = New System.Drawing.Point(252, 244)
        Me.FDA_LIA_euro_centroid.Name = "FDA_LIA_euro_centroid"
        Me.FDA_LIA_euro_centroid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_centroid.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_centroid.TabIndex = 28
        Me.FDA_LIA_euro_centroid.Visible = False
        '
        'FDA_LIA_euro_A
        '
        Me.FDA_LIA_euro_A.ItemHeight = 16
        Me.FDA_LIA_euro_A.Items.AddRange(New Object() {"41.17", "44.925", "48.66", "52.375", "49.825", "54.27", "59.78", "64.175", "63.1", "70.955", "76.875", "70.3", "78.875", "85.275", "97.975", "104.775"})
        Me.FDA_LIA_euro_A.Location = New System.Drawing.Point(252, 216)
        Me.FDA_LIA_euro_A.Name = "FDA_LIA_euro_A"
        Me.FDA_LIA_euro_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_A.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_A.TabIndex = 27
        Me.FDA_LIA_euro_A.Visible = False
        '
        'FDA_LIA_euro_i
        '
        Me.FDA_LIA_euro_i.ItemHeight = 16
        Me.FDA_LIA_euro_i.Items.AddRange(New Object() {"3933.116107", "4276.482807", "4614.877002", "4948.523700", "6500.705375", "7064.054760", "7737.628909", "8286.198607", "10600.312441", "11892.841939", "12825.862233", "14986.893000", "16783.285563", "18074.157630", "25391.485806", "27081.596995"})
        Me.FDA_LIA_euro_i.Location = New System.Drawing.Point(252, 192)
        Me.FDA_LIA_euro_i.Name = "FDA_LIA_euro_i"
        Me.FDA_LIA_euro_i.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_i.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_i.TabIndex = 26
        Me.FDA_LIA_euro_i.Visible = False
        '
        'box07
        '
        Me.box07.Controls.Add(Me.label_y07_unit)
        Me.box07.Controls.Add(Me.textbox_y07)
        Me.box07.Controls.Add(Me.label_a07_unit)
        Me.box07.Controls.Add(Me.textbox_a07)
        Me.box07.Controls.Add(Me.label_m07_unit)
        Me.box07.Controls.Add(Me.textbox_m07)
        Me.box07.Controls.Add(Me.label_y07)
        Me.box07.Controls.Add(Me.label_a07)
        Me.box07.Controls.Add(Me.label_m07)
        Me.box07.Font = New System.Drawing.Font("David", 10.8!)
        Me.box07.Location = New System.Drawing.Point(207, 38)
        Me.box07.Name = "box07"
        Me.box07.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box07.Size = New System.Drawing.Size(364, 136)
        Me.box07.TabIndex = 25
        Me.box07.TabStop = False
        Me.box07.Text = "נתוני החיזוק"
        '
        'label_y07_unit
        '
        Me.label_y07_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y07_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y07_unit.Name = "label_y07_unit"
        Me.label_y07_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y07_unit.TabIndex = 8
        Me.label_y07_unit.Text = "[cm]"
        '
        'textbox_y07
        '
        Me.textbox_y07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y07.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y07.Name = "textbox_y07"
        Me.textbox_y07.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y07.TabIndex = 7
        '
        'label_a07_unit
        '
        Me.label_a07_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a07_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a07_unit.Name = "label_a07_unit"
        Me.label_a07_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a07_unit.TabIndex = 6
        Me.label_a07_unit.Text = "[cm^2]"
        '
        'textbox_a07
        '
        Me.textbox_a07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a07.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a07.Name = "textbox_a07"
        Me.textbox_a07.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a07.TabIndex = 5
        '
        'label_m07_unit
        '
        Me.label_m07_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m07_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m07_unit.Name = "label_m07_unit"
        Me.label_m07_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m07_unit.TabIndex = 4
        Me.label_m07_unit.Text = "[cm^4]"
        '
        'textbox_m07
        '
        Me.textbox_m07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m07.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m07.Name = "textbox_m07"
        Me.textbox_m07.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m07.TabIndex = 3
        '
        'label_y07
        '
        Me.label_y07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y07.Location = New System.Drawing.Point(188, 94)
        Me.label_y07.Name = "label_y07"
        Me.label_y07.Size = New System.Drawing.Size(164, 24)
        Me.label_y07.TabIndex = 2
        Me.label_y07.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a07
        '
        Me.label_a07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a07.Location = New System.Drawing.Point(188, 63)
        Me.label_a07.Name = "label_a07"
        Me.label_a07.Size = New System.Drawing.Size(164, 24)
        Me.label_a07.TabIndex = 1
        Me.label_a07.Text = "שטח חתך החיזוק"
        '
        'label_m07
        '
        Me.label_m07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m07.Location = New System.Drawing.Point(188, 32)
        Me.label_m07.Name = "label_m07"
        Me.label_m07.Size = New System.Drawing.Size(164, 24)
        Me.label_m07.TabIndex = 0
        Me.label_m07.Text = "מומנט אינרציה (Ix)"
        '
        'Label_title07
        '
        Me.Label_title07.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title07.Location = New System.Drawing.Point(12, 20)
        Me.Label_title07.Name = "Label_title07"
        Me.Label_title07.Size = New System.Drawing.Size(196, 20)
        Me.Label_title07.TabIndex = 24
        Me.Label_title07.Text = "שם החיזוק לפי התקן"
        '
        'FDA_LIA_euro_names
        '
        Me.FDA_LIA_euro_names.ItemHeight = 16
        Me.FDA_LIA_euro_names.Items.AddRange(New Object() {"300.0 x 100.0 x 9.5/14.0 IA", "300.0 x 100.0 x 10.5/15.0 IA", "300.0 x 100.0 x 11.5/16.0 IA", "300.0 x 100.0 x 12.5/17.0 IA", "350.0 x 120.0 x 9.5/15.0 IA", "350.0 x 120.0 x 10.5/16.0 IA", "350.0 x 120.0 x 11.5/18.0 IA", "350.0 x 120.0 x 12.5/19.0 IA", "400.0 x 120.0 x 10.0/21.0 IA", "400.0 x 120.0 x 11.5/23.0 IA", "400.0 x 120.0 x 12.5/25.0 IA", "450.0 x 120.0 x 10.0/23.0 IA", "450.0 x 120.0 x 11.5/25.0 IA", "450.0 x 120.0 x 12.5/27.0 IA", "500.0 x 120.0 x 12.5/33.0 IA", "500.0 x 120.0 x 13.5/35.0 IA"})
        Me.FDA_LIA_euro_names.Location = New System.Drawing.Point(16, 46)
        Me.FDA_LIA_euro_names.Name = "FDA_LIA_euro_names"
        Me.FDA_LIA_euro_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_LIA_euro_names.TabIndex = 16
        '
        'ListBox6
        '
        Me.ListBox6.ItemHeight = 16
        Me.ListBox6.Items.AddRange(New Object() {"3", "4", "5", "3", "4", "5", "3", "4", "5", "6", "3", "4", "5", "6", "3", "4", "5", "6", "8", "5", "6", "8", "10", "6", "8", "10", "6", "8", "10", "6", "7", "8", "10", "12", "8", "10", "12", "15", "8", "10", "12", "15", "10", "12", "15", "18", "16", "18", "20", "24"})
        Me.ListBox6.Location = New System.Drawing.Point(148, 372)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox6.Size = New System.Drawing.Size(64, 4)
        Me.ListBox6.TabIndex = 21
        Me.ListBox6.Visible = False
        '
        'FDA_LIA_euro_web_depth
        '
        Me.FDA_LIA_euro_web_depth.ItemHeight = 16
        Me.FDA_LIA_euro_web_depth.Items.AddRange(New Object() {"286", "285", "284", "283", "335", "334", "332", "331", "379", "377", "375", "427", "425", "423", "467", "465"})
        Me.FDA_LIA_euro_web_depth.Location = New System.Drawing.Point(220, 240)
        Me.FDA_LIA_euro_web_depth.Name = "FDA_LIA_euro_web_depth"
        Me.FDA_LIA_euro_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_web_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_web_depth.TabIndex = 19
        Me.FDA_LIA_euro_web_depth.Visible = False
        '
        'FDA_LIA_euro_web_thickness
        '
        Me.FDA_LIA_euro_web_thickness.ItemHeight = 16
        Me.FDA_LIA_euro_web_thickness.Items.AddRange(New Object() {"9.5", "10.5", "11.5", "12.5", "9.5", "10.5", "11.5", "12.5", "10", "11.5", "12.5", "10", "11.5", "12.5", "12.5", "13.5"})
        Me.FDA_LIA_euro_web_thickness.Location = New System.Drawing.Point(220, 216)
        Me.FDA_LIA_euro_web_thickness.Name = "FDA_LIA_euro_web_thickness"
        Me.FDA_LIA_euro_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_web_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_web_thickness.TabIndex = 18
        Me.FDA_LIA_euro_web_thickness.Visible = False
        '
        'FDA_LIA_euro_flange_thickness
        '
        Me.FDA_LIA_euro_flange_thickness.ItemHeight = 16
        Me.FDA_LIA_euro_flange_thickness.Items.AddRange(New Object() {"14", "15", "16", "17", "15", "16", "18", "19", "21", "23", "25", "23", "25", "27", "33", "35"})
        Me.FDA_LIA_euro_flange_thickness.Location = New System.Drawing.Point(220, 264)
        Me.FDA_LIA_euro_flange_thickness.Name = "FDA_LIA_euro_flange_thickness"
        Me.FDA_LIA_euro_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_flange_thickness.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_flange_thickness.TabIndex = 20
        Me.FDA_LIA_euro_flange_thickness.Visible = False
        '
        'FDA_LIA_euro_profile_depth
        '
        Me.FDA_LIA_euro_profile_depth.ItemHeight = 16
        Me.FDA_LIA_euro_profile_depth.Items.AddRange(New Object() {"300", "300", "300", "300", "350", "350", "350", "350", "400", "400", "400", "450", "450", "450", "500", "500"})
        Me.FDA_LIA_euro_profile_depth.Location = New System.Drawing.Point(220, 192)
        Me.FDA_LIA_euro_profile_depth.Name = "FDA_LIA_euro_profile_depth"
        Me.FDA_LIA_euro_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_euro_profile_depth.Size = New System.Drawing.Size(28, 20)
        Me.FDA_LIA_euro_profile_depth.TabIndex = 17
        Me.FDA_LIA_euro_profile_depth.Visible = False
        '
        'FDA_LIA_PIC
        '
        Me.FDA_LIA_PIC.Controls.Add(Me.FDA_LIA_flange_thickness_label)
        Me.FDA_LIA_PIC.Controls.Add(Me.FDA_LIA_flange_breadth_label)
        Me.FDA_LIA_PIC.Controls.Add(Me.FDA_LIA_profile_depth_label)
        Me.FDA_LIA_PIC.Controls.Add(Me.FDA_LIA_web_depth_label)
        Me.FDA_LIA_PIC.Controls.Add(Me.FDA_LIA_web_thickness_label)
        Me.FDA_LIA_PIC.Controls.Add(Me.PictureBox10)
        Me.FDA_LIA_PIC.Location = New System.Drawing.Point(580, 40)
        Me.FDA_LIA_PIC.Name = "FDA_LIA_PIC"
        Me.FDA_LIA_PIC.Size = New System.Drawing.Size(276, 280)
        Me.FDA_LIA_PIC.TabIndex = 23
        Me.FDA_LIA_PIC.TabStop = False
        Me.FDA_LIA_PIC.Text = "Profile: Standard LIA stiffeners (FDA)"
        '
        'FDA_LIA_flange_thickness_label
        '
        Me.FDA_LIA_flange_thickness_label.AutoEllipsis = True
        Me.FDA_LIA_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_LIA_flange_thickness_label.Location = New System.Drawing.Point(13, 60)
        Me.FDA_LIA_flange_thickness_label.Name = "FDA_LIA_flange_thickness_label"
        Me.FDA_LIA_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_flange_thickness_label.Size = New System.Drawing.Size(60, 21)
        Me.FDA_LIA_flange_thickness_label.TabIndex = 15
        '
        'FDA_LIA_flange_breadth_label
        '
        Me.FDA_LIA_flange_breadth_label.AutoEllipsis = True
        Me.FDA_LIA_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_LIA_flange_breadth_label.Location = New System.Drawing.Point(117, 20)
        Me.FDA_LIA_flange_breadth_label.Name = "FDA_LIA_flange_breadth_label"
        Me.FDA_LIA_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_flange_breadth_label.Size = New System.Drawing.Size(72, 20)
        Me.FDA_LIA_flange_breadth_label.TabIndex = 14
        '
        'FDA_LIA_profile_depth_label
        '
        Me.FDA_LIA_profile_depth_label.AutoEllipsis = True
        Me.FDA_LIA_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_LIA_profile_depth_label.Location = New System.Drawing.Point(149, 127)
        Me.FDA_LIA_profile_depth_label.Name = "FDA_LIA_profile_depth_label"
        Me.FDA_LIA_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_profile_depth_label.Size = New System.Drawing.Size(77, 21)
        Me.FDA_LIA_profile_depth_label.TabIndex = 13
        Me.FDA_LIA_profile_depth_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FDA_LIA_web_depth_label
        '
        Me.FDA_LIA_web_depth_label.AutoEllipsis = True
        Me.FDA_LIA_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_LIA_web_depth_label.Location = New System.Drawing.Point(13, 128)
        Me.FDA_LIA_web_depth_label.Name = "FDA_LIA_web_depth_label"
        Me.FDA_LIA_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_web_depth_label.Size = New System.Drawing.Size(60, 20)
        Me.FDA_LIA_web_depth_label.TabIndex = 12
        '
        'FDA_LIA_web_thickness_label
        '
        Me.FDA_LIA_web_thickness_label.AutoEllipsis = True
        Me.FDA_LIA_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_LIA_web_thickness_label.Location = New System.Drawing.Point(65, 216)
        Me.FDA_LIA_web_thickness_label.Name = "FDA_LIA_web_thickness_label"
        Me.FDA_LIA_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_web_thickness_label.Size = New System.Drawing.Size(69, 20)
        Me.FDA_LIA_web_thickness_label.TabIndex = 11
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(73, 44)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        '
        'FDA_LIA_japanese_names
        '
        Me.FDA_LIA_japanese_names.ItemHeight = 16
        Me.FDA_LIA_japanese_names.Items.AddRange(New Object() {"200.0 x 90.0 x 8.0/14.0 IA", "200.0 x 90.0 x 9.0/14.0 IA", "250.0 x 90.0 x 9.0/15.0 IA", "250.0 x 90.0 x 10.0/15.0 IA", "250.0 x 90.0 x 11.0/16.0 IA", "250.0 x 90.0 x 12.0/16.0 IA", "300.0 x 90.0 x 10.0/16.0 IA", "300.0 x 90.0 x 11.0/16.0 IA", "300.0 x 90.0 x 12.0/17.0 IA", "300.0 x 90.0 x 13.0/17.0 IA", "350.0 x 100.0 x 11.0/17.0 IA", "350.0 x 100.0 x 12.0/17.0 IA", "400.0 x 100.0 x 11.5/16.0 IA", "400.0 x 100.0 x 12.0/18.0 IA", "400.0 x 100.0 x 13.0/18.0 IA", "450.0 x 125.0 x 11.5/18.0 IA", "450.0 x 150.0 x 11.5/15.0 IA", "500.0 x 150.0 x 11.5/18.0 IA", "550.0 x 150.0 x 12.0/21.0 IA", "600.0 x 150.0 x 12.5/23.0 IA"})
        Me.FDA_LIA_japanese_names.Location = New System.Drawing.Point(16, 46)
        Me.FDA_LIA_japanese_names.Name = "FDA_LIA_japanese_names"
        Me.FDA_LIA_japanese_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_LIA_japanese_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_LIA_japanese_names.TabIndex = 57
        '
        'FDA_UIA_japanese_korean
        '
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_profile_depth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_flange_breadth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_web_thickness)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_flange_thickness)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_web_depth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.box08)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.Label_title08)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_names)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_profile_depth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_flange_breadth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_web_thickness)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_flange_thickness)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_japanese_web_depth)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_korean_names)
        Me.FDA_UIA_japanese_korean.Controls.Add(Me.FDA_UIA_box)
        Me.FDA_UIA_japanese_korean.Location = New System.Drawing.Point(6, 12)
        Me.FDA_UIA_japanese_korean.Name = "FDA_UIA_japanese_korean"
        Me.FDA_UIA_japanese_korean.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_korean.Size = New System.Drawing.Size(868, 356)
        Me.FDA_UIA_japanese_korean.TabIndex = 15
        Me.FDA_UIA_japanese_korean.TabStop = False
        Me.FDA_UIA_japanese_korean.Text = "FDA_UIA_japanese_korean"
        Me.FDA_UIA_japanese_korean.Visible = False
        '
        'FDA_UIA_korean_profile_depth
        '
        Me.FDA_UIA_korean_profile_depth.ItemHeight = 16
        Me.FDA_UIA_korean_profile_depth.Items.AddRange(New Object() {"90", "100", "100", "125", "125", "125", "125", "125", "150", "150", "150", "150", "150"})
        Me.FDA_UIA_korean_profile_depth.Location = New System.Drawing.Point(304, 280)
        Me.FDA_UIA_korean_profile_depth.Name = "FDA_UIA_korean_profile_depth"
        Me.FDA_UIA_korean_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_korean_profile_depth.TabIndex = 30
        Me.FDA_UIA_korean_profile_depth.Visible = False
        '
        'FDA_UIA_korean_flange_breadth
        '
        Me.FDA_UIA_korean_flange_breadth.ItemHeight = 16
        Me.FDA_UIA_korean_flange_breadth.Items.AddRange(New Object() {"75", "75", "75", "75", "75", "75", "90", "90", "90", "90", "100", "100", "100"})
        Me.FDA_UIA_korean_flange_breadth.Location = New System.Drawing.Point(304, 232)
        Me.FDA_UIA_korean_flange_breadth.Name = "FDA_UIA_korean_flange_breadth"
        Me.FDA_UIA_korean_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_korean_flange_breadth.TabIndex = 28
        Me.FDA_UIA_korean_flange_breadth.Visible = False
        '
        'FDA_UIA_korean_web_thickness
        '
        Me.FDA_UIA_korean_web_thickness.ItemHeight = 16
        Me.FDA_UIA_korean_web_thickness.Items.AddRange(New Object() {"9", "7", "7", "7", "10", "13", "10", "13", "9", "12", "9", "12", "15"})
        Me.FDA_UIA_korean_web_thickness.Location = New System.Drawing.Point(304, 208)
        Me.FDA_UIA_korean_web_thickness.Name = "FDA_UIA_korean_web_thickness"
        Me.FDA_UIA_korean_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_korean_web_thickness.TabIndex = 27
        Me.FDA_UIA_korean_web_thickness.Visible = False
        '
        'FDA_UIA_korean_flange_thickness
        '
        Me.FDA_UIA_korean_flange_thickness.ItemHeight = 16
        Me.FDA_UIA_korean_flange_thickness.Items.AddRange(New Object() {"9", "7", "7", "7", "10", "13", "10", "13", "9", "12", "9", "12", "15"})
        Me.FDA_UIA_korean_flange_thickness.Location = New System.Drawing.Point(304, 256)
        Me.FDA_UIA_korean_flange_thickness.Name = "FDA_UIA_korean_flange_thickness"
        Me.FDA_UIA_korean_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_korean_flange_thickness.TabIndex = 29
        Me.FDA_UIA_korean_flange_thickness.Visible = False
        '
        'FDA_UIA_korean_web_depth
        '
        Me.FDA_UIA_korean_web_depth.ItemHeight = 16
        Me.FDA_UIA_korean_web_depth.Items.AddRange(New Object() {"81", "93", "93", "118", "115", "112", "115", "112", "141", "138", "141", "138", "135"})
        Me.FDA_UIA_korean_web_depth.Location = New System.Drawing.Point(304, 184)
        Me.FDA_UIA_korean_web_depth.Name = "FDA_UIA_korean_web_depth"
        Me.FDA_UIA_korean_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_korean_web_depth.TabIndex = 26
        Me.FDA_UIA_korean_web_depth.Visible = False
        '
        'box08
        '
        Me.box08.Controls.Add(Me.label_y08_unit)
        Me.box08.Controls.Add(Me.textbox_y08)
        Me.box08.Controls.Add(Me.label_a08_unit)
        Me.box08.Controls.Add(Me.textbox_a08)
        Me.box08.Controls.Add(Me.label_m08_unit)
        Me.box08.Controls.Add(Me.textbox_m08)
        Me.box08.Controls.Add(Me.label_y08)
        Me.box08.Controls.Add(Me.label_a08)
        Me.box08.Controls.Add(Me.label_m08)
        Me.box08.Font = New System.Drawing.Font("David", 10.8!)
        Me.box08.Location = New System.Drawing.Point(207, 38)
        Me.box08.Name = "box08"
        Me.box08.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box08.Size = New System.Drawing.Size(364, 136)
        Me.box08.TabIndex = 25
        Me.box08.TabStop = False
        Me.box08.Text = "נתוני החיזוק"
        '
        'label_y08_unit
        '
        Me.label_y08_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y08_unit.Location = New System.Drawing.Point(16, 94)
        Me.label_y08_unit.Name = "label_y08_unit"
        Me.label_y08_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_y08_unit.TabIndex = 8
        Me.label_y08_unit.Text = "[cm]"
        '
        'textbox_y08
        '
        Me.textbox_y08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y08.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y08.Name = "textbox_y08"
        Me.textbox_y08.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y08.TabIndex = 7
        '
        'label_a08_unit
        '
        Me.label_a08_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a08_unit.Location = New System.Drawing.Point(16, 63)
        Me.label_a08_unit.Name = "label_a08_unit"
        Me.label_a08_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_a08_unit.TabIndex = 6
        Me.label_a08_unit.Text = "[cm^2]"
        '
        'textbox_a08
        '
        Me.textbox_a08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a08.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a08.Name = "textbox_a08"
        Me.textbox_a08.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a08.TabIndex = 5
        '
        'label_m08_unit
        '
        Me.label_m08_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m08_unit.Location = New System.Drawing.Point(16, 32)
        Me.label_m08_unit.Name = "label_m08_unit"
        Me.label_m08_unit.Size = New System.Drawing.Size(56, 25)
        Me.label_m08_unit.TabIndex = 4
        Me.label_m08_unit.Text = "[cm^4]"
        '
        'textbox_m08
        '
        Me.textbox_m08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m08.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m08.Name = "textbox_m08"
        Me.textbox_m08.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m08.TabIndex = 3
        '
        'label_y08
        '
        Me.label_y08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y08.Location = New System.Drawing.Point(188, 94)
        Me.label_y08.Name = "label_y08"
        Me.label_y08.Size = New System.Drawing.Size(164, 24)
        Me.label_y08.TabIndex = 2
        Me.label_y08.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a08
        '
        Me.label_a08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a08.Location = New System.Drawing.Point(188, 63)
        Me.label_a08.Name = "label_a08"
        Me.label_a08.Size = New System.Drawing.Size(164, 24)
        Me.label_a08.TabIndex = 1
        Me.label_a08.Text = "שטח חתך החיזוק"
        '
        'label_m08
        '
        Me.label_m08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m08.Location = New System.Drawing.Point(188, 32)
        Me.label_m08.Name = "label_m08"
        Me.label_m08.Size = New System.Drawing.Size(164, 24)
        Me.label_m08.TabIndex = 0
        Me.label_m08.Text = "מומנט אינרציה (Ix)"
        '
        'Label_title08
        '
        Me.Label_title08.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_title08.Location = New System.Drawing.Point(12, 20)
        Me.Label_title08.Name = "Label_title08"
        Me.Label_title08.Size = New System.Drawing.Size(200, 20)
        Me.Label_title08.TabIndex = 24
        Me.Label_title08.Text = "שם החיזוק לפי התקן"
        '
        'FDA_UIA_japanese_names
        '
        Me.FDA_UIA_japanese_names.ItemHeight = 16
        Me.FDA_UIA_japanese_names.Items.AddRange(New Object() {"100.0 x 75.0 x 7.0/7.0 IA", "100.0 x 75.0 x 7.0/7.0 IA", "125.0 x 75.0 x 7.0/7.0 IA", "125.0 x 90.0 x 10.0/10.0 IA", "150.0 x 90.0 x 9.0/9.0 IA", "150.0 x 90.0 x 12.0/12.0 IA"})
        Me.FDA_UIA_japanese_names.Location = New System.Drawing.Point(15, 46)
        Me.FDA_UIA_japanese_names.Name = "FDA_UIA_japanese_names"
        Me.FDA_UIA_japanese_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_UIA_japanese_names.TabIndex = 16
        '
        'FDA_UIA_japanese_profile_depth
        '
        Me.FDA_UIA_japanese_profile_depth.ItemHeight = 16
        Me.FDA_UIA_japanese_profile_depth.Items.AddRange(New Object() {"100", "100", "125", "125", "150", "150"})
        Me.FDA_UIA_japanese_profile_depth.Location = New System.Drawing.Point(228, 280)
        Me.FDA_UIA_japanese_profile_depth.Name = "FDA_UIA_japanese_profile_depth"
        Me.FDA_UIA_japanese_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_japanese_profile_depth.TabIndex = 21
        Me.FDA_UIA_japanese_profile_depth.Visible = False
        '
        'FDA_UIA_japanese_flange_breadth
        '
        Me.FDA_UIA_japanese_flange_breadth.ItemHeight = 16
        Me.FDA_UIA_japanese_flange_breadth.Items.AddRange(New Object() {"75", "75", "75", "90", "90", "90"})
        Me.FDA_UIA_japanese_flange_breadth.Location = New System.Drawing.Point(228, 232)
        Me.FDA_UIA_japanese_flange_breadth.Name = "FDA_UIA_japanese_flange_breadth"
        Me.FDA_UIA_japanese_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_japanese_flange_breadth.TabIndex = 19
        Me.FDA_UIA_japanese_flange_breadth.Visible = False
        '
        'FDA_UIA_japanese_web_thickness
        '
        Me.FDA_UIA_japanese_web_thickness.ItemHeight = 16
        Me.FDA_UIA_japanese_web_thickness.Items.AddRange(New Object() {"7", "7", "7", "10", "9", "12"})
        Me.FDA_UIA_japanese_web_thickness.Location = New System.Drawing.Point(228, 208)
        Me.FDA_UIA_japanese_web_thickness.Name = "FDA_UIA_japanese_web_thickness"
        Me.FDA_UIA_japanese_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_japanese_web_thickness.TabIndex = 18
        Me.FDA_UIA_japanese_web_thickness.Visible = False
        '
        'FDA_UIA_japanese_flange_thickness
        '
        Me.FDA_UIA_japanese_flange_thickness.ItemHeight = 16
        Me.FDA_UIA_japanese_flange_thickness.Items.AddRange(New Object() {"7", "7", "7", "10", "9", "12"})
        Me.FDA_UIA_japanese_flange_thickness.Location = New System.Drawing.Point(228, 256)
        Me.FDA_UIA_japanese_flange_thickness.Name = "FDA_UIA_japanese_flange_thickness"
        Me.FDA_UIA_japanese_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_japanese_flange_thickness.TabIndex = 20
        Me.FDA_UIA_japanese_flange_thickness.Visible = False
        '
        'FDA_UIA_japanese_web_depth
        '
        Me.FDA_UIA_japanese_web_depth.ItemHeight = 16
        Me.FDA_UIA_japanese_web_depth.Items.AddRange(New Object() {"93", "93", "118", "115", "141", "138"})
        Me.FDA_UIA_japanese_web_depth.Location = New System.Drawing.Point(228, 184)
        Me.FDA_UIA_japanese_web_depth.Name = "FDA_UIA_japanese_web_depth"
        Me.FDA_UIA_japanese_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_japanese_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.FDA_UIA_japanese_web_depth.TabIndex = 17
        Me.FDA_UIA_japanese_web_depth.Visible = False
        '
        'FDA_UIA_box
        '
        Me.FDA_UIA_box.Controls.Add(Me.FDA_UIA_flange_thickness_label)
        Me.FDA_UIA_box.Controls.Add(Me.FDA_UIA_flange_breadth_label)
        Me.FDA_UIA_box.Controls.Add(Me.FDA_UIA_profile_depth_label)
        Me.FDA_UIA_box.Controls.Add(Me.FDA_UIA_web_depth_label)
        Me.FDA_UIA_box.Controls.Add(Me.FDA_UIA_web_thickness_label)
        Me.FDA_UIA_box.Controls.Add(Me.PictureBox11)
        Me.FDA_UIA_box.Location = New System.Drawing.Point(580, 40)
        Me.FDA_UIA_box.Name = "FDA_UIA_box"
        Me.FDA_UIA_box.Size = New System.Drawing.Size(276, 280)
        Me.FDA_UIA_box.TabIndex = 23
        Me.FDA_UIA_box.TabStop = False
        Me.FDA_UIA_box.Text = "FDA_UIA_box"
        '
        'FDA_UIA_flange_thickness_label
        '
        Me.FDA_UIA_flange_thickness_label.AutoEllipsis = True
        Me.FDA_UIA_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_UIA_flange_thickness_label.Location = New System.Drawing.Point(12, 60)
        Me.FDA_UIA_flange_thickness_label.Name = "FDA_UIA_flange_thickness_label"
        Me.FDA_UIA_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_flange_thickness_label.Size = New System.Drawing.Size(60, 21)
        Me.FDA_UIA_flange_thickness_label.TabIndex = 15
        '
        'FDA_UIA_flange_breadth_label
        '
        Me.FDA_UIA_flange_breadth_label.AutoEllipsis = True
        Me.FDA_UIA_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_UIA_flange_breadth_label.Location = New System.Drawing.Point(116, 20)
        Me.FDA_UIA_flange_breadth_label.Name = "FDA_UIA_flange_breadth_label"
        Me.FDA_UIA_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_flange_breadth_label.Size = New System.Drawing.Size(72, 20)
        Me.FDA_UIA_flange_breadth_label.TabIndex = 14
        '
        'FDA_UIA_profile_depth_label
        '
        Me.FDA_UIA_profile_depth_label.AutoEllipsis = True
        Me.FDA_UIA_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_UIA_profile_depth_label.Location = New System.Drawing.Point(148, 128)
        Me.FDA_UIA_profile_depth_label.Name = "FDA_UIA_profile_depth_label"
        Me.FDA_UIA_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_profile_depth_label.Size = New System.Drawing.Size(77, 21)
        Me.FDA_UIA_profile_depth_label.TabIndex = 13
        Me.FDA_UIA_profile_depth_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FDA_UIA_web_depth_label
        '
        Me.FDA_UIA_web_depth_label.AutoEllipsis = True
        Me.FDA_UIA_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_UIA_web_depth_label.Location = New System.Drawing.Point(12, 128)
        Me.FDA_UIA_web_depth_label.Name = "FDA_UIA_web_depth_label"
        Me.FDA_UIA_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_web_depth_label.Size = New System.Drawing.Size(60, 20)
        Me.FDA_UIA_web_depth_label.TabIndex = 12
        '
        'FDA_UIA_web_thickness_label
        '
        Me.FDA_UIA_web_thickness_label.AutoEllipsis = True
        Me.FDA_UIA_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.FDA_UIA_web_thickness_label.Location = New System.Drawing.Point(64, 216)
        Me.FDA_UIA_web_thickness_label.Name = "FDA_UIA_web_thickness_label"
        Me.FDA_UIA_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_web_thickness_label.Size = New System.Drawing.Size(69, 20)
        Me.FDA_UIA_web_thickness_label.TabIndex = 11
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(73, 44)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 2
        Me.PictureBox11.TabStop = False
        '
        'FDA_UIA_korean_names
        '
        Me.FDA_UIA_korean_names.ItemHeight = 16
        Me.FDA_UIA_korean_names.Items.AddRange(New Object() {"90.0 x 75.0 x 9.0/9.0 IA", "100.0 x 75.0 x 7.0/7.0 IA", "100.0 x 75.0 x 7.0/7.0 IA", "125.0 x 75.0 x 7.0/7.0 IA", "125.0 x 75.0 x 10.0/10.0 IA", "125.0 x 75.0 x 13.0/13.0 IA", "125.0 x 90.0 x 10.0/10.0 IA", "125.0 x 90.0 x 13.0/13.0 IA", "150.0 x 90.0 x 9.0/9.0 IA", "150.0 x 90.0 x 12.0/12.0 IA", "150.0 x 100.0 x 9.0/9.0 IA", "150.0 x 100.0 x 12.0/12.0 IA", "150.0 x 100.0 x 15.0/15.0 IA"})
        Me.FDA_UIA_korean_names.Location = New System.Drawing.Point(15, 46)
        Me.FDA_UIA_korean_names.Name = "FDA_UIA_korean_names"
        Me.FDA_UIA_korean_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FDA_UIA_korean_names.Size = New System.Drawing.Size(189, 276)
        Me.FDA_UIA_korean_names.TabIndex = 31
        '
        'update_text
        '
        Me.update_text.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.update_text.Location = New System.Drawing.Point(388, 624)
        Me.update_text.Name = "update_text"
        Me.update_text.Size = New System.Drawing.Size(112, 36)
        Me.update_text.TabIndex = 16
        Me.update_text.Text = "אישור"
        Me.update_text.Visible = False
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cancel.Location = New System.Drawing.Point(504, 624)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(112, 36)
        Me.cancel.TabIndex = 17
        Me.cancel.Text = "ביטול"
        Me.cancel.Visible = False
        '
        'stf_box
        '
        Me.stf_box.Controls.Add(Me.FDA_LIU)
        Me.stf_box.Controls.Add(Me.British_Standard_Bulb_corus)
        Me.stf_box.Controls.Add(Me.FDA_bulb02)
        Me.stf_box.Controls.Add(Me.British_Standard_UEA_corus)
        Me.stf_box.Controls.Add(Me.British_Standard_EA_corus)
        Me.stf_box.Controls.Add(Me.FDA_UIA_japanese_korean)
        Me.stf_box.Controls.Add(Me.FDA_bulb01)
        Me.stf_box.Controls.Add(Me.inexa_profil_EA_and_NJA)
        Me.stf_box.Controls.Add(Me.FDA01)
        Me.stf_box.Controls.Add(Me.IP_Rolled_Bulb_Flats)
        Me.stf_box.Controls.Add(Me.Japan_industry_Equal_unequal)
        Me.stf_box.Controls.Add(Me.IP_T)
        Me.stf_box.Controls.Add(Me.IP_Jumbo_bulb)
        Me.stf_box.Location = New System.Drawing.Point(59, 240)
        Me.stf_box.Name = "stf_box"
        Me.stf_box.Size = New System.Drawing.Size(879, 372)
        Me.stf_box.TabIndex = 18
        Me.stf_box.TabStop = False
        '
        'Japan_industry_Equal_unequal
        '
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_flange_thickness)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_flange_thickness)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_Y)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_A)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_I)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_flange_breadth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_web_thickness)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_web_depth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_unequal_profile_depth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.box02)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.label_title02)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_Y)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_A)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_I)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_flange_breadth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_web_thickness)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_web_depth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_profile_depth)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Unequal_names)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_industry_Equal_names)
        Me.Japan_industry_Equal_unequal.Controls.Add(Me.Japan_Industry_Standard_box)
        Me.Japan_industry_Equal_unequal.Location = New System.Drawing.Point(6, 12)
        Me.Japan_industry_Equal_unequal.Name = "Japan_industry_Equal_unequal"
        Me.Japan_industry_Equal_unequal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_unequal.Size = New System.Drawing.Size(868, 356)
        Me.Japan_industry_Equal_unequal.TabIndex = 19
        Me.Japan_industry_Equal_unequal.TabStop = False
        Me.Japan_industry_Equal_unequal.Text = "Japan Industry Standard"
        Me.Japan_industry_Equal_unequal.Visible = False
        '
        'Japan_industry_unequal_flange_thickness
        '
        Me.Japan_industry_unequal_flange_thickness.ItemHeight = 16
        Me.Japan_industry_unequal_flange_thickness.Items.AddRange(New Object() {"7", "10", "7", "10", "9", "12", "14", "14", "15", "15", "16", "16", "16", "16", "17", "17", "17", "17", "16", "18", "18", "18", "15", "18", "21", "23"})
        Me.Japan_industry_unequal_flange_thickness.Location = New System.Drawing.Point(376, 272)
        Me.Japan_industry_unequal_flange_thickness.Name = "Japan_industry_unequal_flange_thickness"
        Me.Japan_industry_unequal_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_flange_thickness.TabIndex = 32
        Me.Japan_industry_unequal_flange_thickness.Visible = False
        '
        'Japan_industry_Equal_flange_thickness
        '
        Me.Japan_industry_Equal_flange_thickness.ItemHeight = 16
        Me.Japan_industry_Equal_flange_thickness.Items.AddRange(New Object() {"6", "8", "6", "9", "12", "10", "13", "10", "13", "12", "15", "12", "15", "20"})
        Me.Japan_industry_Equal_flange_thickness.Location = New System.Drawing.Point(224, 276)
        Me.Japan_industry_Equal_flange_thickness.Name = "Japan_industry_Equal_flange_thickness"
        Me.Japan_industry_Equal_flange_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_flange_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_flange_thickness.TabIndex = 31
        Me.Japan_industry_Equal_flange_thickness.Visible = False
        '
        'Japan_industry_unequal_Y
        '
        Me.Japan_industry_unequal_Y.ItemHeight = 16
        Me.Japan_industry_unequal_Y.Items.AddRange(New Object() {"6.94", "6.82", "8.4", "8.27", "10.04", "9.93", "13.93", "13.64", "16.7", "16.39", "16.26", "16.01", "19.4", "19", "18.9", "18.7", "22.3", "22", "24.7", "24.9", "24.6", "28.8", "28.9", "32.5", "35.7", "38.7"})
        Me.Japan_industry_unequal_Y.Location = New System.Drawing.Point(448, 224)
        Me.Japan_industry_unequal_Y.Name = "Japan_industry_unequal_Y"
        Me.Japan_industry_unequal_Y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_Y.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_Y.TabIndex = 30
        Me.Japan_industry_unequal_Y.Visible = False
        '
        'Japan_industry_unequal_A
        '
        Me.Japan_industry_unequal_A.ItemHeight = 16
        Me.Japan_industry_unequal_A.Items.AddRange(New Object() {"11.87", "16.5", "13.62", "19", "20.94", "27.36", "27.8", "29.66", "35.12", "37.47", "40.61", "42.95", "43.38", "46.22", "49.84", "52.67", "54.41", "57.74", "61.09", "64.77", "68.59", "73.11", "73.45", "83.36", "95.91", "107.6"})
        Me.Japan_industry_unequal_A.Location = New System.Drawing.Point(448, 200)
        Me.Japan_industry_unequal_A.Name = "Japan_industry_unequal_A"
        Me.Japan_industry_unequal_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_A.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_A.TabIndex = 29
        Me.Japan_industry_unequal_A.Visible = False
        '
        'Japan_industry_unequal_I
        '
        Me.Japan_industry_unequal_I.ItemHeight = 16
        Me.Japan_industry_unequal_I.Items.AddRange(New Object() {"118", "159", "219", "298", "484", "619", "1120", "1210", "2280", "2440", "2640", "2740", "4100", "4470", "4690", "4940", "7030", "7440", "10300", "10900", "11500", "15700", "15900", "22300", "31000", "41300"})
        Me.Japan_industry_unequal_I.Location = New System.Drawing.Point(448, 176)
        Me.Japan_industry_unequal_I.Name = "Japan_industry_unequal_I"
        Me.Japan_industry_unequal_I.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_I.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_I.TabIndex = 28
        Me.Japan_industry_unequal_I.Visible = False
        '
        'Japan_industry_unequal_flange_breadth
        '
        Me.Japan_industry_unequal_flange_breadth.ItemHeight = 16
        Me.Japan_industry_unequal_flange_breadth.Items.AddRange(New Object() {"75", "75", "75", "75", "90", "90", "90", "90", "90", "90", "90", "90", "90", "90", "90", "90", "100", "100", "100", "100", "100", "125", "150", "150", "150", "150"})
        Me.Japan_industry_unequal_flange_breadth.Location = New System.Drawing.Point(376, 248)
        Me.Japan_industry_unequal_flange_breadth.Name = "Japan_industry_unequal_flange_breadth"
        Me.Japan_industry_unequal_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_flange_breadth.TabIndex = 27
        Me.Japan_industry_unequal_flange_breadth.Visible = False
        '
        'Japan_industry_unequal_web_thickness
        '
        Me.Japan_industry_unequal_web_thickness.ItemHeight = 16
        Me.Japan_industry_unequal_web_thickness.Items.AddRange(New Object() {"7", "10", "7", "10", "9", "12", "8", "9", "9", "10", "11", "12", "10", "11", "12", "13", "11", "12", "11.5", "12", "13", "11.5", "11.5", "11.5", "12", "12.5"})
        Me.Japan_industry_unequal_web_thickness.Location = New System.Drawing.Point(376, 228)
        Me.Japan_industry_unequal_web_thickness.Name = "Japan_industry_unequal_web_thickness"
        Me.Japan_industry_unequal_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_web_thickness.TabIndex = 26
        Me.Japan_industry_unequal_web_thickness.Visible = False
        '
        'Japan_industry_unequal_web_depth
        '
        Me.Japan_industry_unequal_web_depth.ItemHeight = 16
        Me.Japan_industry_unequal_web_depth.Items.AddRange(New Object() {"93", "90", "118", "115", "141", "138", "186", "186", "235", "235", "234", "234", "284", "284", "283", "283", "333", "333", "384", "382", "382", "432", "435", "482", "529", "577"})
        Me.Japan_industry_unequal_web_depth.Location = New System.Drawing.Point(376, 204)
        Me.Japan_industry_unequal_web_depth.Name = "Japan_industry_unequal_web_depth"
        Me.Japan_industry_unequal_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_web_depth.TabIndex = 25
        Me.Japan_industry_unequal_web_depth.Visible = False
        '
        'Japan_industry_unequal_profile_depth
        '
        Me.Japan_industry_unequal_profile_depth.ItemHeight = 16
        Me.Japan_industry_unequal_profile_depth.Items.AddRange(New Object() {"100", "100", "125", "125", "150", "150", "200", "200", "250", "250", "250", "250", "300", "300", "300", "300", "350", "350", "400", "400", "400", "450", "450", "500", "550", "600"})
        Me.Japan_industry_unequal_profile_depth.Location = New System.Drawing.Point(376, 180)
        Me.Japan_industry_unequal_profile_depth.Name = "Japan_industry_unequal_profile_depth"
        Me.Japan_industry_unequal_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_unequal_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_unequal_profile_depth.TabIndex = 24
        Me.Japan_industry_unequal_profile_depth.Visible = False
        '
        'box02
        '
        Me.box02.Controls.Add(Me.Label_y02_unit)
        Me.box02.Controls.Add(Me.textbox_y02)
        Me.box02.Controls.Add(Me.Label_a02_unit)
        Me.box02.Controls.Add(Me.textbox_a02)
        Me.box02.Controls.Add(Me.Label_m02_unit)
        Me.box02.Controls.Add(Me.textbox_m02)
        Me.box02.Controls.Add(Me.label_y02)
        Me.box02.Controls.Add(Me.label_a02)
        Me.box02.Controls.Add(Me.label_m02)
        Me.box02.Font = New System.Drawing.Font("David", 10.8!)
        Me.box02.Location = New System.Drawing.Point(207, 38)
        Me.box02.Name = "box02"
        Me.box02.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.box02.Size = New System.Drawing.Size(364, 136)
        Me.box02.TabIndex = 15
        Me.box02.TabStop = False
        Me.box02.Text = "נתוני החיזוק"
        '
        'Label_y02_unit
        '
        Me.Label_y02_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_y02_unit.Location = New System.Drawing.Point(16, 94)
        Me.Label_y02_unit.Name = "Label_y02_unit"
        Me.Label_y02_unit.Size = New System.Drawing.Size(56, 24)
        Me.Label_y02_unit.TabIndex = 8
        Me.Label_y02_unit.Text = "[cm]"
        '
        'textbox_y02
        '
        Me.textbox_y02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_y02.Location = New System.Drawing.Point(89, 94)
        Me.textbox_y02.Name = "textbox_y02"
        Me.textbox_y02.Size = New System.Drawing.Size(92, 25)
        Me.textbox_y02.TabIndex = 7
        '
        'Label_a02_unit
        '
        Me.Label_a02_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_a02_unit.Location = New System.Drawing.Point(16, 63)
        Me.Label_a02_unit.Name = "Label_a02_unit"
        Me.Label_a02_unit.Size = New System.Drawing.Size(56, 24)
        Me.Label_a02_unit.TabIndex = 6
        Me.Label_a02_unit.Text = "[cm^2]"
        '
        'textbox_a02
        '
        Me.textbox_a02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_a02.Location = New System.Drawing.Point(89, 63)
        Me.textbox_a02.Name = "textbox_a02"
        Me.textbox_a02.Size = New System.Drawing.Size(92, 25)
        Me.textbox_a02.TabIndex = 5
        '
        'Label_m02_unit
        '
        Me.Label_m02_unit.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_m02_unit.Location = New System.Drawing.Point(16, 32)
        Me.Label_m02_unit.Name = "Label_m02_unit"
        Me.Label_m02_unit.Size = New System.Drawing.Size(56, 24)
        Me.Label_m02_unit.TabIndex = 4
        Me.Label_m02_unit.Text = "[cm^4]"
        '
        'textbox_m02
        '
        Me.textbox_m02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_m02.Location = New System.Drawing.Point(89, 32)
        Me.textbox_m02.Name = "textbox_m02"
        Me.textbox_m02.Size = New System.Drawing.Size(92, 25)
        Me.textbox_m02.TabIndex = 3
        '
        'label_y02
        '
        Me.label_y02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_y02.Location = New System.Drawing.Point(188, 94)
        Me.label_y02.Name = "label_y02"
        Me.label_y02.Size = New System.Drawing.Size(164, 24)
        Me.label_y02.TabIndex = 2
        Me.label_y02.Text = "מיקום מרכז שטח (Y)"
        '
        'label_a02
        '
        Me.label_a02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_a02.Location = New System.Drawing.Point(188, 63)
        Me.label_a02.Name = "label_a02"
        Me.label_a02.Size = New System.Drawing.Size(164, 24)
        Me.label_a02.TabIndex = 1
        Me.label_a02.Text = "שטח חתך החיזוק"
        '
        'label_m02
        '
        Me.label_m02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_m02.Location = New System.Drawing.Point(188, 32)
        Me.label_m02.Name = "label_m02"
        Me.label_m02.Size = New System.Drawing.Size(164, 24)
        Me.label_m02.TabIndex = 0
        Me.label_m02.Text = "מומנט אינרציה (Ix)"
        '
        'label_title02
        '
        Me.label_title02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_title02.Location = New System.Drawing.Point(16, 24)
        Me.label_title02.Name = "label_title02"
        Me.label_title02.Size = New System.Drawing.Size(188, 20)
        Me.label_title02.TabIndex = 1
        Me.label_title02.Text = "שם החיזוק לפי התקן"
        '
        'Japan_Industry_Standard_box
        '
        Me.Japan_Industry_Standard_box.Controls.Add(Me.japan_industry_profile_depth_label)
        Me.Japan_Industry_Standard_box.Controls.Add(Me.japan_industry_flange_breadth_label)
        Me.Japan_Industry_Standard_box.Controls.Add(Me.japan_industry_flange_thickness_label)
        Me.Japan_Industry_Standard_box.Controls.Add(Me.japan_industry_web_thickness_label)
        Me.Japan_Industry_Standard_box.Controls.Add(Me.japan_industry_web_depth_label)
        Me.Japan_Industry_Standard_box.Controls.Add(Me.PictureBox12)
        Me.Japan_Industry_Standard_box.Location = New System.Drawing.Point(580, 40)
        Me.Japan_Industry_Standard_box.Name = "Japan_Industry_Standard_box"
        Me.Japan_Industry_Standard_box.Size = New System.Drawing.Size(276, 280)
        Me.Japan_Industry_Standard_box.TabIndex = 22
        Me.Japan_Industry_Standard_box.TabStop = False
        Me.Japan_Industry_Standard_box.Text = "Japan Industry Standard (Equal Angles)"
        '
        'japan_industry_profile_depth_label
        '
        Me.japan_industry_profile_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.japan_industry_profile_depth_label.Location = New System.Drawing.Point(169, 128)
        Me.japan_industry_profile_depth_label.Name = "japan_industry_profile_depth_label"
        Me.japan_industry_profile_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.japan_industry_profile_depth_label.Size = New System.Drawing.Size(67, 21)
        Me.japan_industry_profile_depth_label.TabIndex = 15
        '
        'japan_industry_flange_breadth_label
        '
        Me.japan_industry_flange_breadth_label.AutoEllipsis = True
        Me.japan_industry_flange_breadth_label.BackColor = System.Drawing.Color.Transparent
        Me.japan_industry_flange_breadth_label.Location = New System.Drawing.Point(136, 16)
        Me.japan_industry_flange_breadth_label.Name = "japan_industry_flange_breadth_label"
        Me.japan_industry_flange_breadth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.japan_industry_flange_breadth_label.Size = New System.Drawing.Size(76, 20)
        Me.japan_industry_flange_breadth_label.TabIndex = 14
        '
        'japan_industry_flange_thickness_label
        '
        Me.japan_industry_flange_thickness_label.AutoEllipsis = True
        Me.japan_industry_flange_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.japan_industry_flange_thickness_label.Location = New System.Drawing.Point(20, 58)
        Me.japan_industry_flange_thickness_label.Name = "japan_industry_flange_thickness_label"
        Me.japan_industry_flange_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.japan_industry_flange_thickness_label.Size = New System.Drawing.Size(65, 20)
        Me.japan_industry_flange_thickness_label.TabIndex = 13
        '
        'japan_industry_web_thickness_label
        '
        Me.japan_industry_web_thickness_label.AutoEllipsis = True
        Me.japan_industry_web_thickness_label.BackColor = System.Drawing.Color.Transparent
        Me.japan_industry_web_thickness_label.Location = New System.Drawing.Point(80, 232)
        Me.japan_industry_web_thickness_label.Name = "japan_industry_web_thickness_label"
        Me.japan_industry_web_thickness_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.japan_industry_web_thickness_label.Size = New System.Drawing.Size(72, 20)
        Me.japan_industry_web_thickness_label.TabIndex = 12
        '
        'japan_industry_web_depth_label
        '
        Me.japan_industry_web_depth_label.AutoEllipsis = True
        Me.japan_industry_web_depth_label.BackColor = System.Drawing.Color.Transparent
        Me.japan_industry_web_depth_label.Location = New System.Drawing.Point(20, 128)
        Me.japan_industry_web_depth_label.Name = "japan_industry_web_depth_label"
        Me.japan_industry_web_depth_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.japan_industry_web_depth_label.Size = New System.Drawing.Size(67, 21)
        Me.japan_industry_web_depth_label.TabIndex = 11
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(88, 40)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(169, 189)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 2
        Me.PictureBox12.TabStop = False
        '
        'Japan_industry_Equal_Y
        '
        Me.Japan_industry_Equal_Y.ItemHeight = 16
        Me.Japan_industry_Equal_Y.Items.AddRange(New Object() {"4.69", "4.62", "5.44", "5.33", "5.21", "6.42", "6.31", "7.17", "7.06", "9.36", "9.24", "10.86", "10.76", "14.33"})
        Me.Japan_industry_Equal_Y.Location = New System.Drawing.Point(292, 228)
        Me.Japan_industry_Equal_Y.Name = "Japan_industry_Equal_Y"
        Me.Japan_industry_Equal_Y.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_Y.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_Y.TabIndex = 10
        Me.Japan_industry_Equal_Y.Visible = False
        '
        'Japan_industry_Equal_A
        '
        Me.Japan_industry_Equal_A.ItemHeight = 16
        Me.Japan_industry_Equal_A.Items.AddRange(New Object() {"7.53", "9.76", "8.73", "12.69", "16.56", "17", "21.71", "19", "24.31", "29.76", "36.75", "34.77", "42.74", "76"})
        Me.Japan_industry_Equal_A.Location = New System.Drawing.Point(292, 204)
        Me.Japan_industry_Equal_A.Name = "Japan_industry_Equal_A"
        Me.Japan_industry_Equal_A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_A.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_A.TabIndex = 9
        Me.Japan_industry_Equal_A.Visible = False
        '
        'Japan_industry_Equal_I
        '
        Me.Japan_industry_Equal_I.ItemHeight = 16
        Me.Japan_industry_Equal_I.Items.AddRange(New Object() {"29.4", "36.8", "46.1", "64.4", "81.9", "125", "156", "175", "220", "467", "568", "740", "888", "2820"})
        Me.Japan_industry_Equal_I.Location = New System.Drawing.Point(292, 180)
        Me.Japan_industry_Equal_I.Name = "Japan_industry_Equal_I"
        Me.Japan_industry_Equal_I.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_I.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_I.TabIndex = 8
        Me.Japan_industry_Equal_I.Visible = False
        '
        'Japan_industry_Equal_flange_breadth
        '
        Me.Japan_industry_Equal_flange_breadth.ItemHeight = 16
        Me.Japan_industry_Equal_flange_breadth.Items.AddRange(New Object() {"65", "65", "75", "75", "75", "90", "90", "100", "100", "130", "130", "150", "150", "200"})
        Me.Japan_industry_Equal_flange_breadth.Location = New System.Drawing.Point(224, 252)
        Me.Japan_industry_Equal_flange_breadth.Name = "Japan_industry_Equal_flange_breadth"
        Me.Japan_industry_Equal_flange_breadth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_flange_breadth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_flange_breadth.TabIndex = 7
        Me.Japan_industry_Equal_flange_breadth.Visible = False
        '
        'Japan_industry_Equal_web_thickness
        '
        Me.Japan_industry_Equal_web_thickness.ItemHeight = 16
        Me.Japan_industry_Equal_web_thickness.Items.AddRange(New Object() {"6", "8", "6", "9", "12", "10", "13", "10", "13", "12", "15", "12", "15", "20"})
        Me.Japan_industry_Equal_web_thickness.Location = New System.Drawing.Point(224, 228)
        Me.Japan_industry_Equal_web_thickness.Name = "Japan_industry_Equal_web_thickness"
        Me.Japan_industry_Equal_web_thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_web_thickness.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_web_thickness.TabIndex = 6
        Me.Japan_industry_Equal_web_thickness.Visible = False
        '
        'Japan_industry_Equal_web_depth
        '
        Me.Japan_industry_Equal_web_depth.ItemHeight = 16
        Me.Japan_industry_Equal_web_depth.Items.AddRange(New Object() {"59", "57", "69", "66", "63", "80", "77", "90", "87", "118", "115", "138", "135", "180"})
        Me.Japan_industry_Equal_web_depth.Location = New System.Drawing.Point(224, 204)
        Me.Japan_industry_Equal_web_depth.Name = "Japan_industry_Equal_web_depth"
        Me.Japan_industry_Equal_web_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_web_depth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_web_depth.TabIndex = 5
        Me.Japan_industry_Equal_web_depth.Visible = False
        '
        'Japan_industry_Equal_profile_depth
        '
        Me.Japan_industry_Equal_profile_depth.ItemHeight = 16
        Me.Japan_industry_Equal_profile_depth.Items.AddRange(New Object() {"65", "65", "75", "75", "75", "90", "90", "100", "100", "130", "130", "150", "150", "200"})
        Me.Japan_industry_Equal_profile_depth.Location = New System.Drawing.Point(224, 180)
        Me.Japan_industry_Equal_profile_depth.Name = "Japan_industry_Equal_profile_depth"
        Me.Japan_industry_Equal_profile_depth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_profile_depth.Size = New System.Drawing.Size(64, 20)
        Me.Japan_industry_Equal_profile_depth.TabIndex = 3
        Me.Japan_industry_Equal_profile_depth.Visible = False
        '
        'Japan_industry_Unequal_names
        '
        Me.Japan_industry_Unequal_names.ItemHeight = 16
        Me.Japan_industry_Unequal_names.Items.AddRange(New Object() {"100x75x7x7", "100x75x10x10", "125x75x7x7", "125x75x10x10", "150x90x9x9", "150x90x12x12", "200x90x8x14", "200x90x9x14", "250x90x9x15", "250x90x10x15", "250x90x11x16", "250x90x12x16", "300x90x10x16", "300x90x11x16", "300x90x12x17", "300x90x13x17", "350x100x11x17", "350x100x12x17", "400x100x11.5x16", "400x100x12x18", "400x100x13x18", "450x125x11.5x18", "450x150x11.5x15", "500x150x11.5x18", "550x150x12x21", "600x150x12.5x23"})
        Me.Japan_industry_Unequal_names.Location = New System.Drawing.Point(15, 46)
        Me.Japan_industry_Unequal_names.Name = "Japan_industry_Unequal_names"
        Me.Japan_industry_Unequal_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Unequal_names.Size = New System.Drawing.Size(189, 276)
        Me.Japan_industry_Unequal_names.TabIndex = 23
        '
        'Japan_industry_Equal_names
        '
        Me.Japan_industry_Equal_names.ItemHeight = 16
        Me.Japan_industry_Equal_names.Items.AddRange(New Object() {"65x65x6x6", "65x65x8x8", "75x75x6x6", "75x75x9x9", "75x75x12x12", "90x90x10x10", "90x90x13x13", "100x100x10x10", "100x100x13x13", "130x130x12x12", "130x130x15x15", "150x150x12x12", "150x150x15x15", "200x200x20x20"})
        Me.Japan_industry_Equal_names.Location = New System.Drawing.Point(15, 46)
        Me.Japan_industry_Equal_names.Name = "Japan_industry_Equal_names"
        Me.Japan_industry_Equal_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Japan_industry_Equal_names.Size = New System.Drawing.Size(189, 276)
        Me.Japan_industry_Equal_names.TabIndex = 0
        '
        'GUI_Database
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(943, 664)
        Me.Controls.Add(Me.stf_box)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.update_text)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.box_standard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI_Database"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "בסיס נתוני חיזוקים"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.British_Standard_Bulb_corus.ResumeLayout(False)
        Me.box06.ResumeLayout(False)
        Me.box06.PerformLayout()
        Me.British_Standard_Bulb_pic_box.ResumeLayout(False)
        CType(Me.British_Standard_Bulb_pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.British_Standard_EA_pic_box.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.British_Standard_EA_corus.ResumeLayout(False)
        Me.box05.ResumeLayout(False)
        Me.box05.PerformLayout()
        Me.British_Standard_UEA_corus.ResumeLayout(False)
        Me.British_Standard_UEA_corus_groupbox.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box04.ResumeLayout(False)
        Me.box04.PerformLayout()
        Me.FDA01.ResumeLayout(False)
        Me.FDA01_pic.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FDA01_blade_pic.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box01.ResumeLayout(False)
        Me.box01.PerformLayout()
        Me.box_standard.ResumeLayout(False)
        CType(Me.british, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inexa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.corus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inexa_profil_EA_and_NJA.ResumeLayout(False)
        Me.box09.ResumeLayout(False)
        Me.box09.PerformLayout()
        Me.IP_pic.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IP_Jumbo_bulb.ResumeLayout(False)
        Me.box10.ResumeLayout(False)
        Me.box10.PerformLayout()
        Me.IP_Jumbo_bulb_groupbox.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IP_Rolled_Bulb_Flats.ResumeLayout(False)
        Me.IP_Rolled_Bulb_Flats_pic.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box11.ResumeLayout(False)
        Me.box11.PerformLayout()
        Me.FDA_bulb01.ResumeLayout(False)
        Me.box12.ResumeLayout(False)
        Me.box12.PerformLayout()
        Me.bulb_pic01.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FDA_bulb02.ResumeLayout(False)
        Me.box13.ResumeLayout(False)
        Me.box13_y13.ResumeLayout(False)
        Me.box13_y13.PerformLayout()
        Me.box13_a13.ResumeLayout(False)
        Me.box13_a13.PerformLayout()
        Me.box13_m13.ResumeLayout(False)
        Me.box13_m13.PerformLayout()
        Me.FDA_bulb02_picbox.ResumeLayout(False)
        CType(Me.bulb02_pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bulb02_pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IP_T.ResumeLayout(False)
        Me.box03.ResumeLayout(False)
        Me.box03.PerformLayout()
        Me.IP_T_groupbox.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FDA_LIU.ResumeLayout(False)
        Me.box07.ResumeLayout(False)
        Me.box07.PerformLayout()
        Me.FDA_LIA_PIC.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FDA_UIA_japanese_korean.ResumeLayout(False)
        Me.box08.ResumeLayout(False)
        Me.box08.PerformLayout()
        Me.FDA_UIA_box.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stf_box.ResumeLayout(False)
        Me.Japan_industry_Equal_unequal.ResumeLayout(False)
        Me.box02.ResumeLayout(False)
        Me.box02.PerformLayout()
        Me.Japan_Industry_Standard_box.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim functions As New models_calculations.Orthotropic_model.model_functions
    Dim general_functions As New general_functions
    Dim FDA_flange_breadth_numeric As Single
    Dim FDA_profile_depth_numeric As Single
    Dim FDA_flange_thickness_numeric As Single
    Dim FDA_web_thickness_numeric As Single
    Dim moment_full As Single
    Dim y_full As Single
    Dim area_full As Single
    Dim selected_moment As Single
    Dim selected_area As Single
    Dim selected_centroid As Single
    Dim current As String
    Public Function GUI_set(ByVal new_lang As String) As Boolean
        language_settings.read_language(new_lang)
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        Me.RightToLeft = language_settings.language_RTL
        Me.Text = language_settings.db_text
        tekens_tree.RightToLeft = language_settings.language_RTL
        tekens_tree.RightToLeftLayout = language_settings.language_RTL_layout
        FDA01.RightToLeft = language_settings.language_RTL
        FDA_bulb01.RightToLeft = language_settings.language_RTL
        FDA_LIU.RightToLeft = language_settings.language_RTL
        FDA_UIA_japanese_korean.RightToLeft = language_settings.language_RTL
        FDA_bulb02.RightToLeft = language_settings.language_RTL
        corus.RightToLeft = language_settings.language_RTL
        British_Standard_Bulb_corus.RightToLeft = language_settings.language_RTL
        British_Standard_EA_corus.RightToLeft = language_settings.language_RTL
        British_Standard_UEA_corus.RightToLeft = language_settings.language_RTL
        Equal_Angles.RightToLeft = language_settings.language_RTL
        inexa_profil_EA_and_NJA.RightToLeft = language_settings.language_RTL
        IP_Rolled_Bulb_Flats.RightToLeft = language_settings.language_RTL
        IP_Jumbo_bulb.RightToLeft = language_settings.language_RTL
        IP_T.RightToLeft = language_settings.language_RTL
        Japan_industry_Equal_unequal.RightToLeft = language_settings.language_RTL
        tekens_tree.Nodes(0).Text = language_settings.Db_text_FDA
        tekens_tree.Nodes.Item(0).Nodes(0).Text = language_settings.db_name05
        tekens_tree.Nodes.Item(0).Nodes(1).Text = language_settings.db_name06
        tekens_tree.Nodes.Item(0).Nodes(2).Text = language_settings.db_name07
        tekens_tree.Nodes.Item(0).Nodes(3).Text = language_settings.db_name08
        tekens_tree.Nodes.Item(0).Nodes(4).Text = language_settings.db_name09
        tekens_tree.Nodes.Item(0).Nodes(5).Text = language_settings.db_name10
        tekens_tree.Nodes.Item(0).Nodes(6).Text = language_settings.db_name11
        tekens_tree.Nodes.Item(0).Nodes(7).Text = language_settings.db_name12
        tekens_tree.Nodes.Item(0).Nodes(8).Text = language_settings.db_name13
        tekens_tree.Nodes.Item(0).Nodes(9).Text = language_settings.db_name14
        tekens_tree.Nodes.Item(0).Nodes(10).Text = language_settings.db_name15
        tekens_tree.Nodes.Item(0).Nodes(11).Text = language_settings.db_name16
        tekens_tree.Nodes.Item(0).Nodes(12).Text = language_settings.db_name17
        tekens_tree.Nodes.Item(0).Nodes(13).Text = language_settings.db_name18
        tekens_tree.Nodes.Item(0).Nodes(14).Text = language_settings.db_name19
        tekens_tree.Nodes.Item(0).Nodes(15).Text = language_settings.db_name20
        tekens_tree.Nodes.Item(0).Nodes(16).Text = language_settings.db_name21
        tekens_tree.Nodes.Item(0).Nodes(17).Text = language_settings.db_name22
        tekens_tree.Nodes.Item(0).Nodes(18).Text = language_settings.db_name23
        tekens_tree.Nodes.Item(0).Nodes(19).Text = language_settings.db_name24
        tekens_tree.Nodes.Item(0).Nodes(20).Text = language_settings.db_name25
        tekens_tree.Nodes(1).Text = language_settings.db_text_Corus
        tekens_tree.Nodes.Item(1).Nodes(0).Text = language_settings.db_name26
        tekens_tree.Nodes.Item(1).Nodes(1).Text = language_settings.db_name27
        tekens_tree.Nodes.Item(1).Nodes(2).Text = language_settings.db_name28
        tekens_tree.Nodes(2).Text = language_settings.db_text_inexa_profil
        tekens_tree.Nodes.Item(2).Nodes(0).Text = language_settings.db_name29
        tekens_tree.Nodes.Item(2).Nodes(1).Text = language_settings.db_name31
        tekens_tree.Nodes.Item(2).Nodes(2).Text = language_settings.db_name30
        tekens_tree.Nodes.Item(2).Nodes(3).Text = language_settings.db_name32
        tekens_tree.Nodes.Item(2).Nodes(4).Text = language_settings.db_name33
        tekens_tree.Nodes(3).Text = language_settings.db_text_japan
        tekens_tree.Nodes.Item(3).Nodes(0).Text = language_settings.db_name34
        tekens_tree.Nodes.Item(3).Nodes(1).Text = language_settings.db_name35
        label_title.Text = language_settings.db_label_title
        update_text.Text = language_settings.db_update
        cancel.Text = language_settings.db_cancel
        Label_count.Text = language_settings.db_Label_count
        box_standard.Text = language_settings.db_box_standard
        Label_y01.Text = language_settings.db_Label_centroid
        label_y02.Text = language_settings.db_Label_centroid
        label_y03.Text = language_settings.db_Label_centroid
        label_y04.Text = language_settings.db_Label_centroid
        label_y05.Text = language_settings.db_Label_centroid
        label_y06.Text = language_settings.db_Label_centroid
        label_y07.Text = language_settings.db_Label_centroid
        label_y08.Text = language_settings.db_Label_centroid
        label_y09.Text = language_settings.db_Label_centroid
        label_y10.Text = language_settings.db_Label_centroid
        label_y11.Text = language_settings.db_Label_centroid
        label_y12.Text = language_settings.db_Label_centroid
        Label_a01.Text = language_settings.db_Label_Area
        label_a02.Text = language_settings.db_Label_Area
        label_a03.Text = language_settings.db_Label_Area
        label_a04.Text = language_settings.db_Label_Area
        label_a05.Text = language_settings.db_Label_Area
        label_a06.Text = language_settings.db_Label_Area
        label_a07.Text = language_settings.db_Label_Area
        label_a08.Text = language_settings.db_Label_Area
        label_a09.Text = language_settings.db_Label_Area
        label_a10.Text = language_settings.db_Label_Area
        label_a11.Text = language_settings.db_Label_Area
        label_a12.Text = language_settings.db_Label_Area
        Label_m01.Text = language_settings.db_Label_Moment
        label_m02.Text = language_settings.db_Label_Moment
        label_m03.Text = language_settings.db_Label_Moment
        label_m04.Text = language_settings.db_Label_Moment
        label_m05.Text = language_settings.db_Label_Moment
        label_m06.Text = language_settings.db_Label_Moment
        label_m07.Text = language_settings.db_Label_Moment
        label_m08.Text = language_settings.db_Label_Moment
        label_m09.Text = language_settings.db_Label_Moment
        label_m10.Text = language_settings.db_Label_Moment
        label_m11.Text = language_settings.db_Label_Moment
        label_m12.Text = language_settings.db_Label_Moment
        box01.Text = language_settings.db_Label_Stiffener_Properties
        box02.Text = language_settings.db_Label_Stiffener_Properties
        box03.Text = language_settings.db_Label_Stiffener_Properties
        box04.Text = language_settings.db_Label_Stiffener_Properties
        box05.Text = language_settings.db_Label_Stiffener_Properties
        box06.Text = language_settings.db_Label_Stiffener_Properties
        box07.Text = language_settings.db_Label_Stiffener_Properties
        box08.Text = language_settings.db_Label_Stiffener_Properties
        box09.Text = language_settings.db_Label_Stiffener_Properties
        box10.Text = language_settings.db_Label_Stiffener_Properties
        box11.Text = language_settings.db_Label_Stiffener_Properties
        box12.Text = language_settings.db_Label_Stiffener_Properties
        box13.Text = language_settings.db_Label_Stiffener_Properties
        Label_title01.Text = language_settings.db_Label_Stiffener_classification
        label_title02.Text = language_settings.db_Label_Stiffener_classification
        Label_title03.Text = language_settings.db_Label_Stiffener_classification
        Label_title04.Text = language_settings.db_Label_Stiffener_classification
        Label_title05.Text = language_settings.db_Label_Stiffener_classification
        Label_title06.Text = language_settings.db_Label_Stiffener_classification
        Label_title07.Text = language_settings.db_Label_Stiffener_classification
        Label_title08.Text = language_settings.db_Label_Stiffener_classification
        Label_title09.Text = language_settings.db_Label_Stiffener_classification
        Label_title10.Text = language_settings.db_Label_Stiffener_classification
        Label_title11.Text = language_settings.db_Label_Stiffener_classification
        Label_title12.Text = language_settings.db_Label_Stiffener_classification
        Label_title13.Text = language_settings.db_Label_Stiffener_classification
        box01.RightToLeft = language_settings.language_RTL
        box02.RightToLeft = language_settings.language_RTL
        box03.RightToLeft = language_settings.language_RTL
        box04.RightToLeft = language_settings.language_RTL
        box05.RightToLeft = language_settings.language_RTL
        box06.RightToLeft = language_settings.language_RTL
        box07.RightToLeft = language_settings.language_RTL
        box08.RightToLeft = language_settings.language_RTL
        box09.RightToLeft = language_settings.language_RTL
        box10.RightToLeft = language_settings.language_RTL
        box11.RightToLeft = language_settings.language_RTL
        box12.RightToLeft = language_settings.language_RTL
        box13.RightToLeft = language_settings.language_RTL
        box13_m13.Text = language_settings.db_Label_Moment
        box13_a13.Text = language_settings.db_Label_Area
        box13_y13.Text = language_settings.db_Label_centroid
        box13_m13.RightToLeft = language_settings.language_RTL
        box13_a13.RightToLeft = language_settings.language_RTL
        box13_y13.RightToLeft = language_settings.language_RTL
        box_standard.RightToLeft = language_settings.language_RTL
        If language_settings.language_RTL_layout = False Then
            tekens_tree.Location = New Point(384, 24)
            '************stiffener 01*********
            Label_m01.Location = New Point(12, 32)
            Label_a01.Location = New Point(12, 63)
            Label_y01.Location = New Point(12, 94)
            textbox_m01.Location = New Point(188, 32)
            textbox_a01.Location = New Point(188, 63)
            textbox_y01.Location = New Point(188, 94)
            Label_title01.Location = New Point(16, 24)
            '************stiffener 02*********
            label_m02.Location = New Point(12, 32)
            label_a02.Location = New Point(12, 63)
            label_y02.Location = New Point(12, 94)
            textbox_m02.Location = New Point(188, 32)
            textbox_a02.Location = New Point(188, 63)
            textbox_y02.Location = New Point(188, 94)
            label_title02.Location = New Point(16, 24)
            '************stiffener 03*********
            label_m03.Location = New Point(12, 32)
            label_a03.Location = New Point(12, 63)
            label_y03.Location = New Point(12, 94)
            textbox_m03.Location = New Point(188, 32)
            textbox_a03.Location = New Point(188, 63)
            textbox_y03.Location = New Point(188, 94)
            Label_title03.Location = New Point(16, 24)
            '************stiffener 04*********
            label_m04.Location = New Point(12, 32)
            label_a04.Location = New Point(12, 63)
            label_y04.Location = New Point(12, 94)
            textbox_m04.Location = New Point(188, 32)
            textbox_a04.Location = New Point(188, 63)
            textbox_y04.Location = New Point(188, 94)
            Label_title04.Location = New Point(16, 24)
            '************stiffener 05*********
            label_m05.Location = New Point(12, 32)
            label_a05.Location = New Point(12, 63)
            label_y05.Location = New Point(12, 94)
            textbox_m05.Location = New Point(188, 32)
            textbox_a05.Location = New Point(188, 63)
            textbox_y05.Location = New Point(188, 94)
            Label_title05.Location = New Point(16, 24)
            '************stiffener 06*********
            label_m06.Location = New Point(12, 32)
            label_a06.Location = New Point(12, 63)
            label_y06.Location = New Point(12, 94)
            textbox_m06.Location = New Point(188, 32)
            textbox_a06.Location = New Point(188, 63)
            textbox_y06.Location = New Point(188, 94)
            Label_title06.Location = New Point(16, 24)
            '************stiffener 07*********
            label_m07.Location = New Point(12, 32)
            label_a07.Location = New Point(12, 63)
            label_y07.Location = New Point(12, 94)
            textbox_m07.Location = New Point(188, 32)
            textbox_a07.Location = New Point(188, 63)
            textbox_y07.Location = New Point(188, 94)
            Label_title07.Location = New Point(16, 24)
            '************stiffener 08*********
            label_m08.Location = New Point(12, 32)
            label_a08.Location = New Point(12, 63)
            label_y08.Location = New Point(12, 94)
            textbox_m08.Location = New Point(188, 32)
            textbox_a08.Location = New Point(188, 63)
            textbox_y08.Location = New Point(188, 94)
            Label_title08.Location = New Point(16, 24)
            '************stiffener 09*********
            label_m09.Location = New Point(12, 32)
            label_a09.Location = New Point(12, 63)
            label_y09.Location = New Point(12, 94)
            textbox_m09.Location = New Point(188, 32)
            textbox_a09.Location = New Point(188, 63)
            textbox_y09.Location = New Point(188, 94)
            Label_title09.Location = New Point(16, 24)
            '************stiffener 10*********
            label_m10.Location = New Point(12, 32)
            label_a10.Location = New Point(12, 63)
            label_y10.Location = New Point(12, 94)
            textbox_m10.Location = New Point(188, 32)
            textbox_a10.Location = New Point(188, 63)
            textbox_y10.Location = New Point(188, 94)
            Label_title10.Location = New Point(16, 24)
            '************stiffener 11*********
            label_m11.Location = New Point(12, 32)
            label_a11.Location = New Point(12, 63)
            label_y11.Location = New Point(12, 94)
            textbox_m11.Location = New Point(188, 32)
            textbox_a11.Location = New Point(188, 63)
            textbox_y11.Location = New Point(188, 94)
            Label_title11.Location = New Point(16, 24)
            '************stiffener 12*********
            label_m12.Location = New Point(12, 32)
            label_a12.Location = New Point(12, 63)
            label_y12.Location = New Point(12, 94)
            textbox_m12.Location = New Point(188, 32)
            textbox_a12.Location = New Point(188, 63)
            textbox_y12.Location = New Point(188, 94)
            Label_title12.Location = New Point(16, 24)
            '************stiffener 13*********
            textbox_m13.Location = New Point(12, 20)
            Label_m13_unit.Location = New Point(115, 20)
            textbox_a13.Location = New Point(12, 20)
            label_a13_unit.Location = New Point(115, 20)
            textbox_y13.Location = New Point(12, 20)
            label_y13_unit.Location = New Point(115, 20)
            '************units*********
            Label_m01_unit.Location = New Point(288, 32)
            Label_a01_unit.Location = New Point(288, 63)
            Label_y01_unit.Location = New Point(288, 94)
            Label_m02_unit.Location = New Point(288, 32)
            Label_a02_unit.Location = New Point(288, 63)
            Label_y02_unit.Location = New Point(288, 94)
            label_m03_unit.Location = New Point(288, 32)
            label_a03_unit.Location = New Point(288, 63)
            label_y03_unit.Location = New Point(288, 94)
            label_m04_unit.Location = New Point(288, 32)
            label_a04_unit.Location = New Point(288, 63)
            label_y04_unit.Location = New Point(288, 94)
            label_m05_unit.Location = New Point(288, 32)
            label_a05_unit.Location = New Point(288, 63)
            label_y05_unit.Location = New Point(288, 94)
            label_m06_unit.Location = New Point(288, 32)
            label_a06_unit.Location = New Point(288, 63)
            label_y06_unit.Location = New Point(288, 94)
            label_m07_unit.Location = New Point(288, 32)
            label_a07_unit.Location = New Point(288, 63)
            label_y07_unit.Location = New Point(288, 94)
            label_m08_unit.Location = New Point(288, 32)
            label_a08_unit.Location = New Point(288, 63)
            label_y08_unit.Location = New Point(288, 94)
            label_m09_unit.Location = New Point(288, 32)
            label_a09_unit.Location = New Point(288, 63)
            label_y09_unit.Location = New Point(288, 94)
            label_m10_unit.Location = New Point(288, 32)
            label_a10_unit.Location = New Point(288, 63)
            label_y10_unit.Location = New Point(288, 94)
            label_m11_unit.Location = New Point(288, 32)
            label_a11_unit.Location = New Point(288, 63)
            label_y11_unit.Location = New Point(288, 94)
            label_m12_unit.Location = New Point(288, 32)
            label_a12_unit.Location = New Point(288, 63)
            label_y12_unit.Location = New Point(288, 94)
        Else
            tekens_tree.Location = New Point(337, 24)
            Label_title01.Location = New Point(16, 24)
            label_title02.Location = New Point(16, 24)
            Label_title03.Location = New Point(16, 24)
            Label_title04.Location = New Point(16, 24)
            Label_title05.Location = New Point(16, 24)
            Label_title06.Location = New Point(16, 24)
            Label_title07.Location = New Point(16, 24)
            Label_title08.Location = New Point(16, 24)
            Label_title09.Location = New Point(16, 24)
            Label_title10.Location = New Point(16, 24)
            Label_title11.Location = New Point(16, 24)
            Label_title12.Location = New Point(16, 24)
            '************stiffener 01*********
            Label_m01.Location = New Point(188, 32)
            Label_a01.Location = New Point(188, 63)
            Label_y01.Location = New Point(188, 94)
            textbox_m01.Location = New Point(89, 32)
            textbox_a01.Location = New Point(89, 63)
            textbox_y01.Location = New Point(89, 94)
            '************stiffener 02*********
            label_m02.Location = New Point(188, 32)
            label_a02.Location = New Point(188, 63)
            label_y02.Location = New Point(188, 94)
            textbox_m02.Location = New Point(89, 32)
            textbox_a02.Location = New Point(89, 63)
            textbox_y02.Location = New Point(89, 94)
            '************stiffener 03*********
            label_m03.Location = New Point(188, 32)
            label_a03.Location = New Point(188, 63)
            label_y03.Location = New Point(188, 94)
            textbox_m03.Location = New Point(89, 32)
            textbox_a03.Location = New Point(89, 63)
            textbox_y03.Location = New Point(89, 94)
            '************stiffener 04*********
            label_m04.Location = New Point(188, 32)
            label_a04.Location = New Point(188, 63)
            label_y04.Location = New Point(188, 94)
            textbox_m04.Location = New Point(89, 32)
            textbox_a04.Location = New Point(89, 63)
            textbox_y04.Location = New Point(89, 94)
            '************stiffener 05*********
            label_m05.Location = New Point(188, 32)
            label_a05.Location = New Point(188, 63)
            label_y05.Location = New Point(188, 94)
            textbox_m05.Location = New Point(89, 32)
            textbox_a05.Location = New Point(89, 63)
            textbox_y05.Location = New Point(89, 94)
            '************stiffener 06*********
            label_m06.Location = New Point(188, 32)
            label_a06.Location = New Point(188, 63)
            label_y06.Location = New Point(188, 94)
            textbox_m06.Location = New Point(89, 32)
            textbox_a06.Location = New Point(89, 63)
            textbox_y06.Location = New Point(89, 94)
            '************stiffener 07*********
            label_m07.Location = New Point(188, 32)
            label_a07.Location = New Point(188, 63)
            label_y07.Location = New Point(188, 94)
            textbox_m07.Location = New Point(89, 32)
            textbox_a07.Location = New Point(89, 63)
            textbox_y07.Location = New Point(89, 94)
            '************stiffener 08*********
            label_m08.Location = New Point(188, 32)
            label_a08.Location = New Point(188, 63)
            label_y08.Location = New Point(188, 94)
            textbox_m08.Location = New Point(89, 32)
            textbox_a08.Location = New Point(89, 63)
            textbox_y08.Location = New Point(89, 94)
            '************stiffener 09*********
            label_m09.Location = New Point(188, 32)
            label_a09.Location = New Point(188, 63)
            label_y09.Location = New Point(188, 94)
            textbox_m09.Location = New Point(89, 32)
            textbox_a09.Location = New Point(89, 63)
            textbox_y09.Location = New Point(89, 94)
            '************stiffener 10*********
            label_m10.Location = New Point(188, 32)
            label_a10.Location = New Point(188, 63)
            label_y10.Location = New Point(188, 94)
            textbox_m10.Location = New Point(89, 32)
            textbox_a10.Location = New Point(89, 63)
            textbox_y10.Location = New Point(89, 94)
            '************stiffener 11*********
            label_m11.Location = New Point(188, 32)
            label_a11.Location = New Point(188, 63)
            label_y11.Location = New Point(188, 94)
            textbox_m11.Location = New Point(89, 32)
            textbox_a11.Location = New Point(89, 63)
            textbox_y11.Location = New Point(89, 94)
            '************stiffener 12*********
            label_m12.Location = New Point(188, 32)
            label_a12.Location = New Point(188, 63)
            label_y12.Location = New Point(188, 94)
            textbox_m12.Location = New Point(89, 32)
            textbox_a12.Location = New Point(89, 63)
            textbox_y12.Location = New Point(89, 94)
            '************stiffener 13*********
            textbox_m13.Location = New Point(85, 20)
            Label_m13_unit.Location = New Point(12, 20)
            textbox_a13.Location = New Point(85, 20)
            label_a13_unit.Location = New Point(12, 20)
            textbox_y13.Location = New Point(85, 20)
            label_y13_unit.Location = New Point(12, 20)
            '************units*********
            '************unit 01*********
            Label_m01_unit.Location = New Point(16, 32)
            Label_a01_unit.Location = New Point(16, 63)
            Label_y01_unit.Location = New Point(16, 94)
            Label_m02_unit.Location = New Point(16, 32)
            Label_a02_unit.Location = New Point(16, 63)
            Label_y02_unit.Location = New Point(16, 94)
            label_m03_unit.Location = New Point(16, 32)
            label_a03_unit.Location = New Point(16, 63)
            label_y03_unit.Location = New Point(16, 94)
            label_m04_unit.Location = New Point(16, 32)
            label_a04_unit.Location = New Point(16, 63)
            label_y04_unit.Location = New Point(16, 94)
            label_m05_unit.Location = New Point(16, 32)
            label_a05_unit.Location = New Point(16, 63)
            label_y05_unit.Location = New Point(16, 94)
            label_m06_unit.Location = New Point(16, 32)
            label_a06_unit.Location = New Point(16, 63)
            label_y06_unit.Location = New Point(16, 94)
            label_m07_unit.Location = New Point(16, 32)
            label_a07_unit.Location = New Point(16, 63)
            label_y07_unit.Location = New Point(16, 94)
            label_m08_unit.Location = New Point(16, 32)
            label_a08_unit.Location = New Point(16, 63)
            label_y08_unit.Location = New Point(16, 94)
            label_m09_unit.Location = New Point(16, 32)
            label_a09_unit.Location = New Point(16, 63)
            label_y09_unit.Location = New Point(16, 94)
            label_m10_unit.Location = New Point(16, 32)
            label_a10_unit.Location = New Point(16, 63)
            label_y10_unit.Location = New Point(16, 94)
            label_m11_unit.Location = New Point(16, 32)
            label_a11_unit.Location = New Point(16, 63)
            label_y11_unit.Location = New Point(16, 94)
            label_m12_unit.Location = New Point(16, 32)
            label_a12_unit.Location = New Point(16, 63)
            label_y12_unit.Location = New Point(16, 94)
        End If
    End Function
    Private Sub British_Standard_Bulb_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles British_Standard_Bulb_names.SelectedIndexChanged
        web_depth_label.Text = British_Standard_Bulb_Web_Depth.Items(British_Standard_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        web_thickness_label.Text = British_Standard_Bulb_Web_thickness.Items(British_Standard_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_radius_label.Text = British_Standard_Bulb_bulb_radius.Items(British_Standard_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        Flange_breadth_label.Text = British_Standard_Bulb_flange_breadth.Items(British_Standard_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter

        textbox_m06.Text = British_Standard_Bulb_Ixx_cm4.Items(British_Standard_Bulb_names.SelectedIndex)
        textbox_a06.Text = British_Standard_Bulb_A_cm2.Items(British_Standard_Bulb_names.SelectedIndex)
        textbox_y06.Text = British_Standard_Bulb_Y_cm.Items(British_Standard_Bulb_names.SelectedIndex)

        selected_moment = British_Standard_Bulb_Ixx_cm4.Items(British_Standard_Bulb_names.SelectedIndex)
        selected_area = British_Standard_Bulb_A_cm2.Items(British_Standard_Bulb_names.SelectedIndex)
        selected_centroid = British_Standard_Bulb_Y_cm.Items(British_Standard_Bulb_names.SelectedIndex)
    End Sub
    Private Sub British_Standard_EA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles British_Standard_EA_names.SelectedIndexChanged
        British_Standard_EA_web_thickness_label.Text = British_Standard_EA_web_thickness.Items(British_Standard_EA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_EA_profile_depth_label.Text = British_Standard_EA_profile_depth.Items(British_Standard_EA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_EA_web_depth_label.Text = British_Standard_EA_web_depth.Items(British_Standard_EA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_EA_flange_thickness_label.Text = British_Standard_EA_flange_thickness.Items(British_Standard_EA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_EA_flange_breadth_label.Text = British_Standard_EA_flange_breadth.Items(British_Standard_EA_names.SelectedIndex) + " " + language_settings.unit_millimeter

        textbox_m05.Text = British_Standard_EA_ix_box.Items(British_Standard_EA_names.SelectedIndex)
        textbox_y05.Text = British_Standard_EA_y_box.Items(British_Standard_EA_names.SelectedIndex)
        textbox_a05.Text = British_Standard_EA_A_box.Items(British_Standard_EA_names.SelectedIndex)

        selected_moment = British_Standard_EA_ix_box.Items(British_Standard_EA_names.SelectedIndex)
        selected_area = British_Standard_EA_A_box.Items(British_Standard_EA_names.SelectedIndex)
        selected_centroid = British_Standard_EA_y_box.Items(British_Standard_EA_names.SelectedIndex)
    End Sub
    Private Sub British_Standard_UEA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles British_Standard_UEA_names.SelectedIndexChanged
        British_Standard_UEA_web_thickness_label.Text = British_Standard_UEA_web_thickness.Items(British_Standard_UEA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_UEA_Profile_depth_label.Text = British_Standard_UEA_profile_depth.Items(British_Standard_UEA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_UEA_web_depth_label.Text = British_Standard_UEA_web_depth.Items(British_Standard_UEA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_UEA_flange_thickness_label.Text = British_Standard_UEA_flange_thickness.Items(British_Standard_UEA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        British_Standard_UEA_flange_breadth_label.Text = British_Standard_UEA_flange_breadth.Items(British_Standard_UEA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m04.Text = British_Standard_UEA_I_box.Items(British_Standard_UEA_names.SelectedIndex)
        textbox_a04.Text = British_Standard_UEA_y_box.Items(British_Standard_UEA_names.SelectedIndex)
        textbox_y04.Text = British_Standard_UEA_a_box.Items(British_Standard_UEA_names.SelectedIndex)
        selected_moment = British_Standard_UEA_I_box.Items(British_Standard_UEA_names.SelectedIndex)
        selected_area = British_Standard_UEA_a_box.Items(British_Standard_UEA_names.SelectedIndex)
        selected_centroid = British_Standard_UEA_y_box.Items(British_Standard_UEA_names.SelectedIndex)
    End Sub
    Private Sub British_Standard_UEA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles British_Standard_UEA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = British_Standard_UEA_FDA_flange_breadth.Items(British_Standard_UEA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = British_Standard_UEA_FDA_profile_depth.Items(British_Standard_UEA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = British_Standard_UEA_FDA_web_thickness.Items(British_Standard_UEA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = British_Standard_UEA_FDA_web_depth.Items(British_Standard_UEA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        general_settings.controls_Library.DB_update = Me.update_text
        general_settings.controls_Library.DB_cancel = Me.cancel
        GUI_set(language_settings.language_current_file)
    End Sub
    Private Sub DIN_Standard_EIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIN_Standard_EIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = DIN_Standard_EIA_FDA_flange_breadth.Items(DIN_Standard_EIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = DIN_Standard_EIA_FDA_profile_depth.Items(DIN_Standard_EIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = DIN_Standard_EIA_FDA_web_thickness.Items(DIN_Standard_EIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = DIN_Standard_EIA_FDA_web_depth.Items(DIN_Standard_EIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub DIN_Standard_UIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIN_Standard_UIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = DIN_Standard_UIA_FDA_flange_breadth.Items(DIN_Standard_UIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = DIN_Standard_UIA_FDA_profile_depth.Items(DIN_Standard_UIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = DIN_Standard_UIA_FDA_web_thickness.Items(DIN_Standard_UIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = DIN_Standard_UIA_FDA_web_depth.Items(DIN_Standard_UIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub European_Standard_UIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles European_Standard_UIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = European_Standard_UIA_FDA_flange_breadth.Items(European_Standard_UIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = European_Standard_UIA_FDA_profile_depth.Items(European_Standard_UIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = European_Standard_UIA_FDA_web_thickness.Items(European_Standard_UIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = European_Standard_UIA_FDA_web_depth.Items(European_Standard_UIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub ISO_Standard_EIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISO_Standard_EIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = ISO_Standard_EIA_FDA_flange_breadth.Items(ISO_Standard_EIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = ISO_Standard_EIA_FDA_profile_depth.Items(ISO_Standard_EIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = ISO_Standard_EIA_FDA_web_thickness.Items(ISO_Standard_EIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = ISO_Standard_EIA_FDA_web_depth.Items(ISO_Standard_EIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub ISO_Standard_UIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISO_Standard_UIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = ISO_Standard_UIA_FDA_flange_breadth.Items(ISO_Standard_UIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = ISO_Standard_UIA_FDA_profile_depth.Items(ISO_Standard_UIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = ISO_Standard_UIA_FDA_web_thickness.Items(ISO_Standard_UIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = ISO_Standard_UIA_FDA_web_depth.Items(ISO_Standard_UIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Japanese_Standard_EIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Japanese_Standard_EIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = Japanese_Standard_EIA_FDA_flange_breadth.Items(Japanese_Standard_EIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = Japanese_Standard_EIA_FDA_profile_depth.Items(Japanese_Standard_EIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = Japanese_Standard_EIA_FDA_web_thickness.Items(Japanese_Standard_EIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = Japanese_Standard_EIA_FDA_web_depth.Items(Japanese_Standard_EIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Korean_Standard_EIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Korean_Standard_EIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = Korean_Standard_EIA_FDA_flange_breadth.Items(Korean_Standard_EIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = Korean_Standard_EIA_FDA_profile_depth.Items(Korean_Standard_EIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = Korean_Standard_EIA_FDA_web_thickness.Items(Korean_Standard_EIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = Korean_Standard_EIA_FDA_web_depth.Items(Korean_Standard_EIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Polish_Standard_EIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Polish_Standard_EIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = Polish_Standard_EIA_FDA_flange_breadth.Items(Polish_Standard_EIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = Polish_Standard_EIA_FDA_profile_depth.Items(Polish_Standard_EIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = Polish_Standard_EIA_FDA_web_thickness.Items(Polish_Standard_EIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = Polish_Standard_EIA_FDA_web_depth.Items(Polish_Standard_EIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Polish_Standard_UIA_FDA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Polish_Standard_UIA_FDA_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = Polish_Standard_UIA_FDA_flange_breadth.Items(Polish_Standard_UIA_FDA_names.SelectedIndex)
        FDA_profile_depth_numeric = Polish_Standard_UIA_FDA_profile_depth.Items(Polish_Standard_UIA_FDA_names.SelectedIndex)
        FDA_flange_thickness_numeric = Polish_Standard_UIA_FDA_web_thickness.Items(Polish_Standard_UIA_FDA_names.SelectedIndex)
        '******************Setting text****************
        FDA_flange_breadth.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_profile_depth.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_web_thickness.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_flange_thickness.Text = FDA_web_thickness.Text
        FDA_web_depth.Text = Polish_Standard_UIA_FDA_web_depth.Items(Polish_Standard_UIA_FDA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Standard_Blades_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Standard_Blades_names.SelectedIndexChanged
        FDA_profile_depth_numeric = Standard_Blades_profiles_depth.Items(Standard_Blades_names.SelectedIndex)
        FDA_web_thickness_numeric = Standard_Blades_web_thickness.Items(Standard_Blades_names.SelectedIndex)
        '******************Setting text****************
        Standard_Blades_web_thickness_label.Text = CStr(FDA_web_thickness_numeric) + " " + language_settings.unit_millimeter
        Standard_Blades_profiles_depth_label.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_web_thickness_numeric, FDA_profile_depth_numeric, 0, 0, "|")
        area_full = models_calculations.general_functions.Area(FDA_web_thickness_numeric, FDA_profile_depth_numeric, 0, 0, "|")
        y_full = models_calculations.general_functions.centroid(FDA_web_thickness_numeric, FDA_profile_depth_numeric, 0, 0, "|")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m01.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a01.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y01.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub Equal_Angles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Equal_Angles.SelectedIndexChanged
        Equal_Angles_flange_thickness_label.Text = Equal_Angles_flange_thickness.Items(Equal_Angles.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_flange_breadth_label.Text = Equal_Angles_flange_breadth.Items(Equal_Angles.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_web_depth_label.Text = Equal_Angles_web_depth.Items(Equal_Angles.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_web_thickness_label.Text = Equal_Angles_web_thickness.Items(Equal_Angles.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m09.Text = Equal_Angles_I.Items(Equal_Angles.SelectedIndex)
        textbox_a09.Text = Equal_Angles_area.Items(Equal_Angles.SelectedIndex)
        textbox_y09.Text = Equal_Angles_y.Items(Equal_Angles.SelectedIndex)
        selected_moment = Equal_Angles_I.Items(Equal_Angles.SelectedIndex)
        selected_area = Equal_Angles_area.Items(Equal_Angles.SelectedIndex)
        selected_centroid = Equal_Angles_y.Items(Equal_Angles.SelectedIndex)
    End Sub
    Private Sub IP_Jumbo_Bulb_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_Jumbo_Bulb_names.SelectedIndexChanged
        IP_Jumbo_Bulb_bulb_radius_label.Text = IP_Jumbo_Bulb_bulb_radius.Items(IP_Jumbo_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_Jumbo_Bulb_flange_breadth_label.Text = IP_Jumbo_Bulb_flange_breadth.Items(IP_Jumbo_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_Jumbo_Bulb_web_depth_label.Text = IP_Jumbo_Bulb_web_depth.Items(IP_Jumbo_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_Jumbo_Bulb_web_thickness_label.Text = IP_Jumbo_Bulb_web_thickness.Items(IP_Jumbo_Bulb_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m10.Text = IP_Jumbo_Bulb_i.Items(IP_Jumbo_Bulb_names.SelectedIndex)
        textbox_a10.Text = IP_Jumbo_Bulb_A.Items(IP_Jumbo_Bulb_names.SelectedIndex)
        textbox_y10.Text = IP_Jumbo_Bulb_Y.Items(IP_Jumbo_Bulb_names.SelectedIndex)
        selected_moment = IP_Jumbo_Bulb_i.Items(IP_Jumbo_Bulb_names.SelectedIndex)
        selected_area = IP_Jumbo_Bulb_A.Items(IP_Jumbo_Bulb_names.SelectedIndex)
        selected_centroid = IP_Jumbo_Bulb_Y.Items(IP_Jumbo_Bulb_names.SelectedIndex)
    End Sub
    Private Sub NJA_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJA_names.SelectedIndexChanged
        Equal_Angles_flange_thickness_label.Text = NJA_flange_thickness.Items(NJA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_flange_breadth_label.Text = NJA_flange_breadth.Items(NJA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_web_depth_label.Text = NJA_web_depth.Items(NJA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        Equal_Angles_web_thickness_label.Text = NJA_web_thickness.Items(NJA_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m09.Text = NJA_I.Items(NJA_names.SelectedIndex)
        textbox_a09.Text = NJA_area.Items(NJA_names.SelectedIndex)
        textbox_y09.Text = NJA_y.Items(NJA_names.SelectedIndex)
        selected_moment = NJA_I.Items(NJA_names.SelectedIndex)
        selected_area = NJA_area.Items(NJA_names.SelectedIndex)
        selected_centroid = NJA_y.Items(NJA_names.SelectedIndex)
    End Sub
    Private Sub IP_rolled_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_rolled_names.SelectedIndexChanged
        IP_rolled_bulb_radius_label.Text = IP_rolled_bulb_radius.Items(IP_rolled_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_rolled_flange_breadth_label.Text = IP_rolled_flange_breadth.Items(IP_rolled_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_rolled_web_depth_label.Text = IP_rolled_web_depth.Items(IP_rolled_names.SelectedIndex) + " " + language_settings.unit_millimeter
        IP_rolled_web_thickness_label.Text = IP_rolled_web_thickness.Items(IP_rolled_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m11.Text = IP_rolled_i.Items(IP_rolled_names.SelectedIndex)
        textbox_a11.Text = IP_rolled_a.Items(IP_rolled_names.SelectedIndex)
        textbox_y11.Text = IP_rolled_centroid.Items(IP_rolled_names.SelectedIndex)
        selected_moment = IP_rolled_i.Items(IP_rolled_names.SelectedIndex)
        selected_area = IP_rolled_a.Items(IP_rolled_names.SelectedIndex)
        selected_centroid = IP_rolled_centroid.Items(IP_rolled_names.SelectedIndex)
    End Sub
    Private Sub DIN_HBP_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIN_HBP_names.SelectedIndexChanged
        bulb_profile_depth_label.Text = DIN_HBP_profile_depth.Items(DIN_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_web_thickness_label.Text = DIN_HBP_web_thickness.Items(DIN_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_flange_breadth_label.Text = DIN_HBP_flange_breadth.Items(DIN_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_radius_din_label.Text = DIN_HBP_bulb_radius.Items(DIN_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m12.Text = DIN_HBP_i.Items(DIN_HBP_names.SelectedIndex)
        textbox_a12.Text = DIN_HBP_a.Items(DIN_HBP_names.SelectedIndex)
        textbox_y12.Text = DIN_HBP_y.Items(DIN_HBP_names.SelectedIndex)
        selected_moment = DIN_HBP_i.Items(DIN_HBP_names.SelectedIndex)
        selected_area = DIN_HBP_a.Items(DIN_HBP_names.SelectedIndex)
        selected_centroid = DIN_HBP_y.Items(DIN_HBP_names.SelectedIndex)
    End Sub
    Private Sub ISO_HBP_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISO_HBP_names.SelectedIndexChanged
        bulb_profile_depth_label.Text = ISO_HBP_profile_depth.Items(ISO_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_web_thickness_label.Text = ISO_HBP_web_thickness.Items(ISO_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_flange_breadth_label.Text = ISO_HBP_flange_breadth.Items(ISO_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb_radius_din_label.Text = ISO_HBP_bulb_radius.Items(ISO_HBP_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m12.Text = ISO_HBP_i.Items(ISO_HBP_names.SelectedIndex)
        textbox_a12.Text = ISO_HBP_a.Items(ISO_HBP_names.SelectedIndex)
        textbox_y12.Text = ISO_HBP_y.Items(ISO_HBP_names.SelectedIndex)
        selected_moment = ISO_HBP_i.Items(ISO_HBP_names.SelectedIndex)
        selected_area = ISO_HBP_a.Items(ISO_HBP_names.SelectedIndex)
        selected_centroid = ISO_HBP_y.Items(ISO_HBP_names.SelectedIndex)
    End Sub
    Private Sub bulb02_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulb02_names.SelectedIndexChanged
        If bulb02_names.SelectedIndex < 4 Then
            FDA_bulb02_picbox.Text = language_settings.db_name01
            bulb02_pic01.Visible = True
            bulb02_pic02.Visible = False
        ElseIf bulb02_names.SelectedIndex < 8 Then
            FDA_bulb02_picbox.Text = language_settings.db_name02
            bulb02_pic01.Visible = True
            bulb02_pic02.Visible = False
        ElseIf bulb02_names.SelectedIndex < 14 Then
            FDA_bulb02_picbox.Text = language_settings.db_name03
            bulb02_pic02.Visible = True
            bulb02_pic01.Visible = False
        Else
            FDA_bulb02_picbox.Text = language_settings.db_name04
            bulb02_pic01.Visible = True
            bulb02_pic02.Visible = False
        End If
        bulb02_profile_depth_label.Text = bulb02_profile_depth.Items(bulb02_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb02_web_thickness_label.Text = bulb02_web_thickness.Items(bulb02_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb02_flange_breadth_label.Text = bulb02_flange_breadth.Items(bulb02_names.SelectedIndex) + " " + language_settings.unit_millimeter
        bulb02_bulb_radius_label.Text = bulb02_bulb_radius.Items(bulb02_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m13.Text = bulb02_i.Items(bulb02_names.SelectedIndex)
        textbox_a13.Text = bulb02_a.Items(bulb02_names.SelectedIndex)
        textbox_y13.Text = bulb02_centroid.Items(bulb02_names.SelectedIndex)
        selected_moment = bulb02_i.Items(bulb02_names.SelectedIndex)
        selected_area = bulb02_a.Items(bulb02_names.SelectedIndex)
        selected_centroid = bulb02_centroid.Items(bulb02_names.SelectedIndex)
    End Sub
    Private Sub IP_T_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_T_names.SelectedIndexChanged
        T_flange_thickness_label.Text = T_flange_thickness.Items(IP_T_names.SelectedIndex) + " " + language_settings.unit_millimeter
        T_web_depth_label.Text = T_web_depth.Items(IP_T_names.SelectedIndex) + " " + language_settings.unit_millimeter
        T_web_thickness_label.Text = T_web_thickness.Items(IP_T_names.SelectedIndex) + " " + language_settings.unit_millimeter
        T_flange_breadth_label.Text = T_flange_breadth.Items(IP_T_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m03.Text = T_i.Items(IP_T_names.SelectedIndex)
        textbox_a03.Text = T_a.Items(IP_T_names.SelectedIndex)
        textbox_y03.Text = T_centroid.Items(IP_T_names.SelectedIndex)
        selected_moment = T_i.Items(IP_T_names.SelectedIndex)
        selected_area = T_a.Items(IP_T_names.SelectedIndex)
        selected_centroid = T_centroid.Items(IP_T_names.SelectedIndex)
    End Sub
    Private Sub FDA_LIA_euro_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_LIA_euro_names.SelectedIndexChanged
        FDA_LIA_flange_breadth_label.Text = FDA_LIA_euro_flange_breadth.Items(FDA_LIA_euro_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_profile_depth_label.Text = FDA_LIA_euro_profile_depth.Items(FDA_LIA_euro_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_depth_label.Text = FDA_LIA_euro_web_depth.Items(FDA_LIA_euro_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_thickness_label.Text = FDA_LIA_euro_web_thickness.Items(FDA_LIA_euro_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_flange_thickness_label.Text = FDA_LIA_euro_flange_thickness.Items(FDA_LIA_euro_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_y07.Text = FDA_LIA_euro_centroid.Items(FDA_LIA_euro_names.SelectedIndex)
        textbox_a07.Text = FDA_LIA_euro_A.Items(FDA_LIA_euro_names.SelectedIndex)
        textbox_m07.Text = FDA_LIA_euro_i.Items(FDA_LIA_euro_names.SelectedIndex)
        selected_moment = FDA_LIA_euro_i.Items(FDA_LIA_euro_names.SelectedIndex)
        selected_area = FDA_LIA_euro_A.Items(FDA_LIA_euro_names.SelectedIndex)
        selected_centroid = FDA_LIA_euro_centroid.Items(FDA_LIA_euro_names.SelectedIndex)
    End Sub
    Private Sub FDA_LIA_ISO_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_LIA_ISO_names.SelectedIndexChanged
        FDA_LIA_flange_breadth_label.Text = FDA_LIA_ISO_flange_breadth.Items(FDA_LIA_ISO_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_profile_depth_label.Text = FDA_LIA_ISO_profile_depth.Items(FDA_LIA_ISO_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_depth_label.Text = FDA_LIA_ISO_web_depth.Items(FDA_LIA_ISO_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_thickness_label.Text = FDA_LIA_ISO_web_thickness.Items(FDA_LIA_ISO_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_flange_thickness_label.Text = FDA_LIA_ISO_flange_thickness.Items(FDA_LIA_ISO_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m07.Text = FDA_LIA_ISO_i.Items(FDA_LIA_ISO_names.SelectedIndex)
        textbox_a07.Text = FDA_LIA_ISO_A.Items(FDA_LIA_ISO_names.SelectedIndex)
        textbox_y07.Text = FDA_LIA_ISO_centroid.Items(FDA_LIA_ISO_names.SelectedIndex)
        selected_moment = FDA_LIA_ISO_i.Items(FDA_LIA_ISO_names.SelectedIndex)
        selected_area = FDA_LIA_ISO_A.Items(FDA_LIA_ISO_names.SelectedIndex)
        selected_centroid = FDA_LIA_ISO_centroid.Items(FDA_LIA_ISO_names.SelectedIndex)
    End Sub
    Private Sub FDA_LIA_Korean_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_LIA_Korean_names.SelectedIndexChanged
        FDA_LIA_flange_breadth_label.Text = FDA_LIA_Korean_flange_breadth.Items(FDA_LIA_Korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_profile_depth_label.Text = FDA_LIA_Korean_profile_depth.Items(FDA_LIA_Korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_depth_label.Text = FDA_LIA_Korean_web_depth.Items(FDA_LIA_Korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_thickness_label.Text = FDA_LIA_Korean_web_thickness.Items(FDA_LIA_Korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_flange_thickness_label.Text = FDA_LIA_Korean_flange_thickness.Items(FDA_LIA_Korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m07.Text = FDA_LIA_Korean_i.Items(FDA_LIA_Korean_names.SelectedIndex)
        textbox_a07.Text = FDA_LIA_Korean_A.Items(FDA_LIA_Korean_names.SelectedIndex)
        textbox_y07.Text = FDA_LIA_Korean_centroid.Items(FDA_LIA_Korean_names.SelectedIndex)
        selected_moment = FDA_LIA_Korean_i.Items(FDA_LIA_Korean_names.SelectedIndex)
        selected_area = FDA_LIA_Korean_A.Items(FDA_LIA_Korean_names.SelectedIndex)
        selected_centroid = FDA_LIA_Korean_centroid.Items(FDA_LIA_Korean_names.SelectedIndex)
    End Sub
    Private Sub FDA_LIA_nordic_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_LIA_nordic_names.SelectedIndexChanged
        FDA_LIA_flange_breadth_label.Text = FDA_LIA_nordic_flange_breadth.Items(FDA_LIA_nordic_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_profile_depth_label.Text = FDA_LIA_nordic_profile_depth.Items(FDA_LIA_nordic_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_depth_label.Text = FDA_LIA_nordic_web_depth.Items(FDA_LIA_nordic_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_thickness_label.Text = FDA_LIA_nordic_web_thickness.Items(FDA_LIA_nordic_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_flange_thickness_label.Text = FDA_LIA_nordic_flange_thickness.Items(FDA_LIA_nordic_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m07.Text = FDA_LIA_nordic_i.Items(FDA_LIA_nordic_names.SelectedIndex)
        textbox_a07.Text = FDA_LIA_nordic_A.Items(FDA_LIA_nordic_names.SelectedIndex)
        textbox_y07.Text = FDA_LIA_nordic_centroid.Items(FDA_LIA_nordic_names.SelectedIndex)
        selected_moment = FDA_LIA_nordic_i.Items(FDA_LIA_nordic_names.SelectedIndex)
        selected_area = FDA_LIA_nordic_A.Items(FDA_LIA_nordic_names.SelectedIndex)
        selected_centroid = FDA_LIA_nordic_centroid.Items(FDA_LIA_nordic_names.SelectedIndex)
    End Sub
    Private Sub FDA_LIA_japanese_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_LIA_japanese_names.SelectedIndexChanged
        FDA_LIA_flange_breadth_label.Text = FDA_LIA_japanese_flange_breadth.Items(FDA_LIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_profile_depth_label.Text = FDA_LIA_japanese_profile_depth.Items(FDA_LIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_depth_label.Text = FDA_LIA_japanese_web_depth.Items(FDA_LIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_web_thickness_label.Text = FDA_LIA_japanese_web_thickness.Items(FDA_LIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        FDA_LIA_flange_thickness_label.Text = FDA_LIA_japanese_flange_thickness.Items(FDA_LIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m07.Text = FDA_LIA_japanese_i.Items(FDA_LIA_japanese_names.SelectedIndex)
        textbox_a07.Text = FDA_LIA_japanese_A.Items(FDA_LIA_japanese_names.SelectedIndex)
        textbox_y07.Text = FDA_LIA_japanese_centroid.Items(FDA_LIA_japanese_names.SelectedIndex)
        selected_moment = FDA_LIA_japanese_i.Items(FDA_LIA_japanese_names.SelectedIndex)
        selected_area = FDA_LIA_japanese_A.Items(FDA_LIA_japanese_names.SelectedIndex)
        selected_centroid = FDA_LIA_japanese_centroid.Items(FDA_LIA_japanese_names.SelectedIndex)
    End Sub
    Private Sub FDA_UIA_japanese_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_UIA_japanese_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = FDA_UIA_japanese_flange_breadth.Items(FDA_UIA_japanese_names.SelectedIndex)
        FDA_profile_depth_numeric = FDA_UIA_japanese_profile_depth.Items(FDA_UIA_japanese_names.SelectedIndex)
        FDA_flange_thickness_numeric = FDA_UIA_japanese_flange_thickness.Items(FDA_UIA_japanese_names.SelectedIndex)
        '******************Setting text****************
        FDA_UIA_flange_breadth_label.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_profile_depth_label.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_flange_thickness_label.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_web_thickness_label.Text = FDA_UIA_flange_thickness_label.Text
        FDA_UIA_web_depth_label.Text = FDA_UIA_japanese_web_depth.Items(FDA_UIA_japanese_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m08.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a08.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y08.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub FDA_UIA_korean_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDA_UIA_korean_names.SelectedIndexChanged
        FDA_flange_breadth_numeric = FDA_UIA_korean_flange_breadth.Items(FDA_UIA_korean_names.SelectedIndex)
        FDA_profile_depth_numeric = FDA_UIA_korean_profile_depth.Items(FDA_UIA_korean_names.SelectedIndex)
        FDA_flange_thickness_numeric = FDA_UIA_korean_flange_thickness.Items(FDA_UIA_korean_names.SelectedIndex)
        '******************Setting text****************
        FDA_UIA_flange_breadth_label.Text = CStr(FDA_flange_breadth_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_profile_depth_label.Text = CStr(FDA_profile_depth_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_flange_thickness_label.Text = CStr(FDA_flange_thickness_numeric) + " " + language_settings.unit_millimeter
        FDA_UIA_web_thickness_label.Text = FDA_UIA_flange_thickness_label.Text
        FDA_UIA_web_depth_label.Text = FDA_UIA_korean_web_depth.Items(FDA_UIA_korean_names.SelectedIndex) + " " + language_settings.unit_millimeter
        '**************Calulating data******************
        moment_full = models_calculations.general_functions.moment_of_inertia(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        y_full = models_calculations.general_functions.centroid(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        area_full = models_calculations.general_functions.Area(FDA_flange_breadth_numeric, FDA_profile_depth_numeric, FDA_flange_thickness_numeric, 0, "L")
        selected_moment = moment_full * 10 ^ 8
        selected_area = area_full * 10 ^ 4
        selected_centroid = y_full * 10 ^ 2
        '**************feeding to textbox******************
        textbox_m08.Text = Math.Round(moment_full * 10 ^ 8, 3)
        textbox_a08.Text = Math.Round(area_full * 10 ^ 4, 3)
        textbox_y08.Text = Math.Round(y_full * 10 ^ 2, 3)
    End Sub
    Private Sub update_text_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_text.Click
        ' TO BE COMPLETE LATER
        If general_settings.controls_Library.current_lang = "hebrew" Then
            Dim response As MsgBoxResult
            Dim msg1 As String = "מומנט אינרציה:" + CStr(selected_moment) + " [cm^4]"
            Dim msg2 As String = "שטח חתך:" + CStr(selected_area) + " [cm^2]"
            Dim msg3 As String = "מיקום מרכז שטח:" + CStr(selected_centroid) + " [cm]"
            Dim msg4 As String = "האם נתונים אלו נכונים?"
            response = MsgBox(msg1 + Chr(13) + msg2 + Chr(13) + msg3 + Chr(13) + Chr(13) + msg4, MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Information + MsgBoxStyle.YesNo, "נתוני החיזוק הנבחר")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                general_settings.controls_Library.DB_moment.Text = selected_moment
                general_settings.controls_Library.DB_area.Text = selected_area
                general_settings.controls_Library.DB_centroid.Text = selected_centroid
                general_settings.controls_Library.form_change.Enabled = True
                Me.Close()
            End If
        Else
            Dim response As MsgBoxResult
            Dim msg1 As String = "Moment of Inertia:" + CStr(selected_moment) + " [cm^4]"
            Dim msg2 As String = "Area of cross section:" + CStr(selected_area) + " [cm^2]"
            Dim msg3 As String = "Centroid:" + CStr(selected_centroid) + " [cm]"
            Dim msg4 As String = "Is the data currect?"
            response = MsgBox(msg1 + Chr(13) + msg2 + Chr(13) + msg3 + Chr(13) + Chr(13) + msg4, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Properties of selected stiffener")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                general_settings.controls_Library.DB_moment.Text = selected_moment
                general_settings.controls_Library.DB_area.Text = selected_area
                general_settings.controls_Library.DB_centroid.Text = selected_centroid
                general_settings.controls_Library.form_change.Enabled = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub database_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If cancel.Visible = True Then
            general_settings.controls_Library.form_change.Enabled = True
        End If
    End Sub
    Private Sub undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        general_settings.controls_Library.form_change.Enabled = True
        Me.Close()
    End Sub
    Private Sub tekens_tree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tekens_tree.AfterSelect
        Japan_industry_Equal_unequal.Visible = False
        Japan_industry_Unequal_names.Visible = False
        Japan_industry_Equal_names.Visible = False
        corus.Visible = False
        corus_link.Visible = False
        inexa.Visible = False
        inexa_link.Visible = False
        ISO.Visible = False
        ISO_link.Visible = False
        DIN.Visible = False
        DIN_link.Visible = False
        british.Visible = False
        british_link.Visible = False
        FDA_LIA_japanese_names.Visible = False
        FDA_LIA_euro_names.Visible = False
        FDA_LIA_ISO_names.Visible = False
        FDA_LIA_Korean_names.Visible = False
        FDA_LIA_nordic_names.Visible = False
        IP_T.Visible = False
        FDA_flange_breadth.Text = ""
        FDA_profile_depth.Text = ""
        FDA_flange_thickness.Text = ""
        FDA_web_depth.Text = ""
        FDA_web_thickness.Text = ""
        FDA01_blade_pic.Visible = False
        FDA01_pic.Visible = False
        textbox_m01.Text = ""
        textbox_y01.Text = ""
        textbox_a01.Text = ""
        FDA01.Visible = False
        British_Standard_Bulb_corus.Visible = False
        British_Standard_UEA_corus.Visible = False
        British_Standard_EA_corus.Visible = False
        British_Standard_UEA_FDA_names.Visible = False
        DIN_Standard_EIA_FDA_names.Visible = False
        DIN_Standard_UIA_FDA_names.Visible = False
        European_Standard_UIA_FDA_names.Visible = False
        ISO_Standard_EIA_FDA_names.Visible = False
        ISO_Standard_UIA_FDA_names.Visible = False
        Japanese_Standard_EIA_FDA_names.Visible = False
        Korean_Standard_EIA_FDA_names.Visible = False
        Polish_Standard_EIA_FDA_names.Visible = False
        Polish_Standard_UIA_FDA_names.Visible = False
        Standard_Blades_names.Visible = False
        inexa_profil_EA_and_NJA.Visible = False
        Equal_Angles.Visible = False
        IP_Jumbo_bulb.Visible = False
        NJA_names.Visible = False
        IP_Rolled_Bulb_Flats.Visible = False
        DIN_HBP_names.Visible = False
        ISO_HBP_names.Visible = False
        FDA_bulb01.Visible = False
        FDA_bulb02.Visible = False
        FDA_LIU.Visible = False
        FDA_UIA_japanese_names.Visible = False
        FDA_UIA_korean_names.Visible = False
        FDA_UIA_japanese_korean.Visible = False
        current = tekens_tree.SelectedNode.Text
        Select Case current
            Case language_settings.db_name05
                FDA01.Text = language_settings.db_name05 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                British_Standard_UEA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name05 + " (" + language_settings.Db_text_FDA + ")"
                british.Visible = True
                british_link.Visible = True
            Case language_settings.db_name06
                FDA01.Text = language_settings.db_name06 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                DIN_Standard_EIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name06 + " (" + language_settings.Db_text_FDA + ")"
                DIN.Visible = True
                DIN_link.Visible = True
            Case language_settings.db_name07
                FDA01.Text = language_settings.db_name07 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                DIN_Standard_UIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name07 + " (" + language_settings.Db_text_FDA + ")"
                DIN.Visible = True
                DIN_link.Visible = True
            Case language_settings.db_name08
                FDA_bulb01.Text = language_settings.db_name08 + " (" + language_settings.Db_text_FDA + ")"
                DIN_HBP_names.Visible = True
                FDA_bulb01.Visible = True
                bulb_pic01.Text = language_settings.db_text_profile + " " + language_settings.db_name08 + " (" + language_settings.Db_text_FDA + ")"
                DIN.Visible = True
                DIN_link.Visible = True
            Case language_settings.db_name09
                FDA_LIA_euro_names.Visible = True
                FDA_LIA_PIC.Text = language_settings.db_text_profile + " " + language_settings.db_name09 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Text = language_settings.db_name09 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Visible = True
            Case language_settings.db_name10
                FDA01.Text = language_settings.db_name10 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                European_Standard_UIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name10 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name11
                FDA01.Text = language_settings.db_name11 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                ISO_Standard_EIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name11 + " (" + language_settings.Db_text_FDA + ")"
                ISO.Visible = True
                ISO_link.Visible = True
            Case language_settings.db_name12
                FDA_LIA_ISO_names.Visible = True
                FDA_LIA_PIC.Text = language_settings.db_text_profile + " " + language_settings.db_name12 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Text = language_settings.db_name12 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Visible = True
                ISO.Visible = True
                ISO_link.Visible = True
            Case language_settings.db_name13
                FDA01.Text = language_settings.db_name13 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                ISO_Standard_UIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name13 + " (" + language_settings.Db_text_FDA + ")"
                ISO.Visible = True
                ISO_link.Visible = True
            Case language_settings.db_name14
                FDA_bulb01.Text = language_settings.db_name14 + " (" + language_settings.Db_text_FDA + ")"
                ISO_HBP_names.Visible = True
                FDA_bulb01.Visible = True
                bulb_pic01.Text = language_settings.db_text_profile + " " + language_settings.db_name14 + " (" + language_settings.Db_text_FDA + ")"
                ISO.Visible = True
                ISO_link.Visible = True
            Case language_settings.db_name15
                FDA01.Text = language_settings.db_name15 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                Japanese_Standard_EIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name15 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name16
                FDA_LIA_japanese_names.Visible = True
                FDA_LIA_PIC.Text = language_settings.db_text_profile + " " + language_settings.db_name16 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Text = language_settings.db_name16 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Visible = True
            Case language_settings.db_name17
                FDA_UIA_box.Text = language_settings.db_text_profile + " " + language_settings.db_name17 + " (" + language_settings.Db_text_FDA + ")"
                FDA_UIA_japanese_names.Visible = True
                FDA_UIA_japanese_korean.Text = language_settings.db_name17 + " (" + language_settings.Db_text_FDA + ")"
                FDA_UIA_japanese_korean.Visible = True
            Case language_settings.db_name18
                FDA01.Text = language_settings.db_name18 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                Korean_Standard_EIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name18 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name19
                FDA_LIA_Korean_names.Visible = True
                FDA_LIA_PIC.Text = language_settings.db_text_profile + " " + language_settings.db_name19 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Text = language_settings.db_name19 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Visible = True
            Case language_settings.db_name20
                FDA_UIA_box.Text = language_settings.db_text_profile + " " + language_settings.db_name20 + " (" + language_settings.Db_text_FDA + ")"
                FDA_UIA_korean_names.Visible = True
                FDA_UIA_japanese_korean.Text = language_settings.db_name20 + " (" + language_settings.Db_text_FDA + ")"
                FDA_UIA_japanese_korean.Visible = True
            Case language_settings.db_name21
                FDA_LIA_nordic_names.Visible = True
                FDA_LIA_PIC.Text = language_settings.db_text_profile + " " + language_settings.db_name21 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Text = language_settings.db_name21 + " (" + language_settings.Db_text_FDA + ")"
                FDA_LIU.Visible = True
            Case language_settings.db_name22
                FDA01.Text = language_settings.db_name22 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                Polish_Standard_EIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name22 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name23
                FDA01.Text = language_settings.db_name23 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_pic.Visible = True
                Polish_Standard_UIA_FDA_names.Visible = True
                FDA01_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name23 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name24
                FDA01.Text = language_settings.db_name24 + " (" + language_settings.Db_text_FDA + ")"
                FDA01.Visible = True
                FDA01_blade_pic.Visible = True
                Standard_Blades_names.Visible = True
                FDA01_blade_pic.Text = language_settings.db_text_profile + " " + language_settings.db_name24 + " (" + language_settings.Db_text_FDA + ")"
            Case language_settings.db_name25
                FDA_bulb02.Visible = True
                FDA_bulb02.Text = language_settings.db_name25
                FDA_bulb02_picbox.Text = language_settings.db_text_profile + " " + language_settings.db_name25
            Case language_settings.db_text_Corus
                corus.Visible = True
                corus_link.Visible = True
            Case language_settings.db_name26
                British_Standard_Bulb_corus.Visible = True
                British_Standard_Bulb_corus.Text = language_settings.db_name26
                British_Standard_Bulb_pic_box.Text = language_settings.db_text_profile + " " + language_settings.db_name26
                corus.Visible = True
                corus_link.Visible = True
            Case language_settings.db_name27
                British_Standard_EA_corus.Visible = True
                British_Standard_EA_corus.Text = language_settings.db_name27
                British_Standard_EA_pic_box.Text = language_settings.db_text_profile + " " + language_settings.db_name27
                corus.Visible = True
                corus_link.Visible = True
            Case language_settings.db_name28
                British_Standard_UEA_corus.Visible = True
                British_Standard_UEA_corus.Text = language_settings.db_name28
                British_Standard_UEA_corus_groupbox.Text = language_settings.db_text_profile + " " + language_settings.db_name28
                corus.Visible = True
                corus_link.Visible = True
            Case language_settings.db_text_inexa_profil
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name29
                inexa_profil_EA_and_NJA.Visible = True
                inexa_profil_EA_and_NJA.Text = language_settings.db_text_inexa_profil + " - " + language_settings.db_name29
                Equal_Angles.Visible = True
                IP_pic.Text = language_settings.db_text_profile + " " + language_settings.db_text_inexa_profil + " (" + language_settings.db_name29 + ")"
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name30
                IP_Jumbo_bulb.Visible = True
                IP_Jumbo_bulb.Text = language_settings.db_text_inexa_profil + " - " + language_settings.db_name30
                IP_Jumbo_bulb_groupbox.Text = language_settings.db_text_profile + " " + language_settings.db_text_inexa_profil + " (" + language_settings.db_name30 + ")"
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name31
                inexa_profil_EA_and_NJA.Visible = True
                inexa_profil_EA_and_NJA.Text = language_settings.db_text_inexa_profil + " - " + language_settings.db_name31
                NJA_names.Visible = True
                IP_pic.Text = language_settings.db_text_profile + " " + language_settings.db_text_inexa_profil + " (" + language_settings.db_name31 + ")"
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name32
                IP_Rolled_Bulb_Flats.Visible = True
                IP_Rolled_Bulb_Flats.Text = language_settings.db_text_inexa_profil + " - " + language_settings.db_name32
                IP_Rolled_Bulb_Flats_pic.Text = language_settings.db_text_profile + " " + language_settings.db_text_inexa_profil + " (" + language_settings.db_name32 + ")"
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name33
                IP_T_groupbox.Text = language_settings.db_text_profile + " " + language_settings.db_text_inexa_profil + " (" + language_settings.db_name33 + ")"
                IP_T.Visible = True
                IP_T.Text = language_settings.db_text_inexa_profil + " - " + language_settings.db_name33
                inexa.Visible = True
                inexa_link.Visible = True
            Case language_settings.db_name34 'Japan industry Equal L
                Japan_industry_Equal_unequal.Text = language_settings.db_text_japan
                Japan_Industry_Standard_box.Text = language_settings.db_name34
                Japan_industry_Equal_names.Visible = True
                Japan_industry_Equal_unequal.Visible = True
                japan_industry_flange_breadth_label.Text = ""
                japan_industry_profile_depth_label.Text = ""
                japan_industry_web_depth_label.Text = ""
                japan_industry_web_thickness_label.Text = ""
                japan_industry_flange_thickness_label.Text = ""
            Case language_settings.db_name35 'Japan industry Unequal L
                Japan_industry_Equal_unequal.Text = language_settings.db_text_japan
                Japan_Industry_Standard_box.Text = language_settings.db_name35
                Japan_industry_Unequal_names.Visible = True
                Japan_industry_Equal_unequal.Visible = True
                japan_industry_flange_breadth_label.Text = ""
                japan_industry_profile_depth_label.Text = ""
                japan_industry_web_depth_label.Text = ""
                japan_industry_web_thickness_label.Text = ""
                japan_industry_flange_thickness_label.Text = ""
        End Select
    End Sub
    Private Sub corus_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles corus_link.LinkClicked
        System.Diagnostics.Process.Start(corus_link.Text)
    End Sub
    Private Sub inexa_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles inexa_link.LinkClicked
        System.Diagnostics.Process.Start(inexa_link.Text)
    End Sub
    Private Sub ISO_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ISO_link.LinkClicked
        System.Diagnostics.Process.Start(ISO_link.Text)
    End Sub
    Private Sub DIN_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DIN_link.LinkClicked
        System.Diagnostics.Process.Start(DIN_link.Text)
    End Sub
    Private Sub british_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles british_link.LinkClicked
        System.Diagnostics.Process.Start(british_link.Text)
    End Sub
    Private Sub Japan_industry_Unequal_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Japan_industry_Unequal_names.SelectedIndexChanged
        japan_industry_flange_breadth_label.Text = Japan_industry_unequal_flange_breadth.Items(Japan_industry_Unequal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_profile_depth_label.Text = Japan_industry_unequal_profile_depth.Items(Japan_industry_Unequal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_web_depth_label.Text = Japan_industry_unequal_web_depth.Items(Japan_industry_Unequal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_web_thickness_label.Text = Japan_industry_unequal_web_thickness.Items(Japan_industry_Unequal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_flange_thickness_label.Text = Japan_industry_unequal_flange_thickness.Items(Japan_industry_Unequal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m02.Text = Japan_industry_unequal_I.Items(Japan_industry_Unequal_names.SelectedIndex)
        textbox_a02.Text = Japan_industry_unequal_A.Items(Japan_industry_Unequal_names.SelectedIndex)
        textbox_y02.Text = Japan_industry_unequal_Y.Items(Japan_industry_Unequal_names.SelectedIndex)
        selected_moment = Japan_industry_unequal_I.Items(Japan_industry_Unequal_names.SelectedIndex)
        selected_area = Japan_industry_unequal_A.Items(Japan_industry_Unequal_names.SelectedIndex)
        selected_centroid = Japan_industry_unequal_Y.Items(Japan_industry_Unequal_names.SelectedIndex)
    End Sub
    Private Sub Japan_industry_Equal_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Japan_industry_Equal_names.SelectedIndexChanged
        japan_industry_flange_breadth_label.Text = Japan_industry_Equal_flange_breadth.Items(Japan_industry_Equal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_profile_depth_label.Text = Japan_industry_Equal_profile_depth.Items(Japan_industry_Equal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_web_depth_label.Text = Japan_industry_Equal_web_depth.Items(Japan_industry_Equal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_web_thickness_label.Text = Japan_industry_Equal_web_thickness.Items(Japan_industry_Equal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        japan_industry_flange_thickness_label.Text = Japan_industry_Equal_flange_thickness.Items(Japan_industry_Equal_names.SelectedIndex) + " " + language_settings.unit_millimeter
        textbox_m02.Text = Japan_industry_Equal_I.Items(Japan_industry_Equal_names.SelectedIndex)
        textbox_a02.Text = Japan_industry_Equal_A.Items(Japan_industry_Equal_names.SelectedIndex)
        textbox_y02.Text = Japan_industry_Equal_Y.Items(Japan_industry_Equal_names.SelectedIndex)
        selected_moment = Japan_industry_Equal_I.Items(Japan_industry_Equal_names.SelectedIndex)
        selected_area = Japan_industry_Equal_A.Items(Japan_industry_Equal_names.SelectedIndex)
        selected_centroid = Japan_industry_Equal_Y.Items(Japan_industry_Equal_names.SelectedIndex)
    End Sub
End Class
