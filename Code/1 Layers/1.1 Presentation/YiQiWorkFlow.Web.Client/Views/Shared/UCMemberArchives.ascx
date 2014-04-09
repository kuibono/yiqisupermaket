<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%--<div class="ablock">
    <label for="Control_CardNumber">卡号:</label>
    <input type="text" class="mini-textbox" name="CardNumber" id="Control_CardNumber" vtype="maxLength:20" allowinput="false"  />
</div>--%>

<form runat="server" id="UCMemberArchivesForm">
    <div class="ablock hidden">
        <label for="Control_MsCode">会员编码:</label>
        <input id="Control_MsCode" name="Id" class="mini-textbox"  />
    </div>

    <div class="ablock">
        <label for="Control_MsName">会员姓名:</label>
        <input type="text" class="mini-textbox" name="MsName" id="Control_MsName" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_Birthday">出生日期:</label>
        <input type="text" id="Control_Birthday" name="Birthday" class="mini-datepicker" format="yyyy-MM-dd" showtime="false" showokbutton="true" showclearbutton="true"  />
    </div>

    <div class="ablock">
        <label for="Control_Sex">性别:</label>
        <input type="text" class="mini-combobox" name="Sex" id="Control_Sex" data="c_Sex" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_PoliticsCode">政治面貌编码:</label>
        <input type="text" class="mini-combobox" name="PoliticsCode" id="Control_PoliticsCode" data="c_PoliticsCode" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_NationCode">民族编码:</label>
        <input type="text" class="mini-combobox" name="NationCode" id="Control_NationCode" data="c_NationCode" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_EducationCode">学历编码:</label>
        <input type="text" class="mini-combobox" name="EducationCode" id="Control_EducationCode" data="c_EducationCode" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_ProfessionalTitleCode">职称编码:</label>
        <input type="text" class="mini-combobox" name="ProfessionalTitleCode" id="Control_ProfessionalTitleCode" data="c_ProfessionalTitleCode" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_IfMarried">婚否:</label>
        <div id="Control_IfMarried" name="IfMarried" value="1" class="mini-checkbox" truevalue="1" falsevalue="0" checked="true"  text="婚否"></div>
    </div>

    <div class="ablock">
        <label for="Control_NativePlace">籍贯:</label>
        <input type="text" class="mini-textbox" name="NativePlace" id="Control_NativePlace" vtype="maxLength:40"  />
    </div>

    <div class="ablock">
        <label for="Control_Idcard">身份证号:</label>
        <input type="text" class="mini-textbox" name="Idcard" id="Control_Idcard" onvalidation="onIDCardsValidation" vtype="maxLength:20" enable="false" />
    </div>

    <div class="ablock">
        <label for="Control_FamilyPhone">家庭电话:</label>
        <input type="text" class="mini-textbox" name="FamilyPhone" id="Control_FamilyPhone" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_Handset">手机:</label>
        <input type="text" class="mini-textbox" name="Handset" id="Control_Handset" vtype="maxLength:20"  />
    </div>

    <div class="ablock">
        <label for="Control_eMail">E-mail:</label>
        <input type="text" class="mini-textbox" name="eMail" id="Control_eMail" vtype="maxLength:30"  />
    </div>

    <div class="ablock">
        <label for="Control_FamilyAddress">家庭住址:</label>
        <input type="text" class="mini-textbox" name="FamilyAddress" id="Control_FamilyAddress" vtype="maxLength:40"  />
    </div>

    <div class="ablock">
        <label for="Control_Postalcode">邮政编码:</label>
        <input type="text" class="mini-textbox" name="Postalcode" id="Control_Postalcode" vtype="rangeChar:6,6"  />
    </div>

    <div class="ablock">
        <label for="Control_Stature">身高:</label>
        <input type="text" id="Control_Stature" name="Stature" class="mini-spinner" minvalue="0" maxvalue="220" decimalplaces="2"  />
    </div>

    <div class="ablock">
        <label for="Control_Width">体重:</label>
        <input type="text" id="Control_Width" name="Width" class="mini-spinner" minvalue="0" maxvalue="300" decimalplaces="2"  />
    </div>
</form>
