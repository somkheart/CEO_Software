using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop;
using System.IO;
using Microsoft.Office.Interop.Word;
using CEO_Devices.SmartCard;
using System.Drawing.Imaging;
using System.Drawing;
namespace CEO_Utils.OfficeTools
{
    public class MirosoftWord
    {


        public static void CreateWordProfile(CEO_SmartCard SmartCardInfo,Object oTemplatePath, Object NewFile)
        {
              Object oMissing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = new Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Field myMergeField in wordDoc.Fields)
            {

                
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();
                  

                    /*  1.เลขที่บัตรประชาชน */
                    if (fieldName == "NationID")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.NationalID);
                    }

                    /*  2.คำนำหน้าชื่อภาษาไทย */
                    if (fieldName == "ThaiTitle")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.ThaiTitle);
                    }

                    /*  3.ชื่อภาษาไทย */
                    if (fieldName == "ThaiName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.ThaiName);
                    }


                    /*  4.ชื่อเล่นภาษาไทย */
                    if (fieldName == "ThaiMiddleName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.ThaiName);
                    }


                    /*  5.นามสกุลภาษาไทย */

                     if (fieldName == "ThaiSurname")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.ThaiSurname);
                    }

                    /*  6.คำนำหน้าชื่อภาษาอังกฤษ */
                    

                      if (fieldName == "EnglishTitle")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.EnglishTitle);
                    }

                    /*  7.ชื่อภาษาอังกฤษ */
                    if (fieldName == "EnglishName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.EnglishName);
                    }

                    /*  8.ชื่อเล่นภาษาอังกฤษ */
                    
                    if (fieldName == "EnglishMiddleName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.EnglishMiddleName);
                    }

                    /*  9.นามสกุลภาษาอังกฤษ */
                    
                   if (fieldName == "EnglishSurname")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.EnglishSurname);
                    }

                    /*  10.ที่อยู่ */
                    
                   if (fieldName == "Address")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Address);
                    }

                    /*  11.หมู่ */
                    
                     if (fieldName == "Moo")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Moo.ToString());
                    }

                    /*  12.ตรอก */
                    if (fieldName == "Trok")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Trok);
                    }
                    /*  13.ซอย */
                  
                    if (fieldName == "Soi")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Soi);
                    }

                    /*  14.ถนน */
                    
                    if (fieldName == "Thanon")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Thanon);
                    }
                    /*  15.ตำบล */
                    
                    if (fieldName == "Tumbol")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Tumbol);
                    }

                    /*  16.อำเภอ */
                    if (fieldName == "Amphur")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Amphur);
                    }

                    /*  17.จังหวัด */
                   if (fieldName == "Province")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Province);
                    }
                    /*  18.สถานที่ออกบัตร */
                   if (fieldName == "IssuePlace")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.IssuePlace);
                    }

                    /*  19.เพศ */
                    if (fieldName == "Sex")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Sex.ToString());
                    }
                    /*  20.วันเกิด */
                    
                     if (fieldName == "BirthDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.Birthdate);
                    }
                    /*  21. วันที่ออกบัตร  */
                    if (fieldName == "IssueDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.IssueDate);
                    }

                    /*  22.วันที่บัตรหมดอายุ */
                     if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(SmartCardInfo.ExpireDate);
                    }

                    /*  23.ภาพ */

                     if (fieldName == "Photo")
                    {
                        object missing = System.Reflection.Missing.Value;
                        object Visible = true;
                        object start1 = 0;
                        object end1 = 0;
                        String tmpImage = "c:\\" + SmartCardInfo.NationalID + ".jpg";
                        Image thumbnail = SmartCardInfo.Photo.GetThumbnailImage(120, 120, null, IntPtr.Zero);
                        thumbnail.Save(tmpImage, ImageFormat.Jpeg);

                        wordDoc.InlineShapes.AddPicture(tmpImage, ref missing, ref missing, ref missing);
                        myMergeField.Select();
                        wordApp.Selection.TypeText(" ");
                    }


                }

            }
            wordDoc.SaveAs(NewFile);
            wordApp.Documents.Open(NewFile);
            wordApp.Application.Quit();
        }

            

    }
}
