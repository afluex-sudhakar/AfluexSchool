﻿using AfluexSchool.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APSSchool.Models
{
    public class API
    {
    }



    public class Login
    {
        public string Password { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string LoginId { get; set; }
        public string Pk_ParentID { get; set; }
        public string DeviceId { get; set; }
        public string FireBaseId { get; set; }


        public string ParentName { get; set; }

        public DataSet LoginAction()
        {
            SqlParameter[] para ={new SqlParameter ("@LoginId",LoginId),
                                new SqlParameter("@Password",Password),
             new SqlParameter("@UserType","4")};
            DataSet ds = Connection.ExecuteQuery("Login", para);
            return ds;
        }
        public DataSet TeacherLoginAction()
        {
            SqlParameter[] para ={new SqlParameter ("@LoginId",LoginId),
                                new SqlParameter("@Password",Password),
             new SqlParameter("@UserType","3")};
            DataSet ds = Connection.ExecuteQuery("Login", para);
            return ds;
        }
        public DataSet SaveDeviceDetails()
        {
            SqlParameter[] para ={
                                    new SqlParameter ("@DeviceId",DeviceId),
                                    new SqlParameter("@FireBaseId",FireBaseId),
                                    new SqlParameter("@AddedBy",Pk_ParentID),
                                };
            DataSet ds = Connection.ExecuteQuery("SaveDeviceDetails", para);
            return ds;
        }
    }

    public class DashBoard1
    {
        public string Status { get; set; }
        public string Fk_ParentId { get; set; }
        public List<StudentData> lstdashboarddata { get; set; }
        public DataSet GetDashBoardDetails()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Fk_ParentId",Fk_ParentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetDashBoardDetailsForParent", para);
            return ds;
        }

    }
    public class StudentData
    {
        public string Title { get; set; }
        public List<StudentDetails> StudentDetails { get; set; }
    }
    public class StudentDetails
    {
        public string StudentName { get; set; }
        public string Pk_StudentId { get; set; }

        public string State { get; set; }
        public string City { get; set; }
        public string StudentPhoto { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string FatherOcc { get; set; }
        public string MotherOcc { get; set; }
        public string PermanentAddress { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string RollNo { get; set; }
    }




    public class Attendance
    {
        public List<Data1> AttendanceList { get; set; }
        public List<Data> MonthList { get; set; }
        public string Pk_StudentId { get; set; }
        public string TotalLeave { get; set; }
        public string TotalAbsent { get; set; }
        public string TotalPresent { get; set; }
        public string Status { get; set; }
        public string Year { get; set; }

        public string Month { get; set; }

        public DataSet GetAttendanceDetails()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_StudentID",Pk_StudentId ),

                                  };
            DataSet ds = Connection.ExecuteQuery("GetStudentAttendanceDetail", para);
            return ds;
        }

        public DataSet GetAttendanceDetailsNew()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_StudentID",Pk_StudentId ),
                                     new SqlParameter("@Year",Year ),
                                      new SqlParameter("@Month",Month ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetStudentAttendanceForMobile", para);
            return ds;
        }

    }
    public class Data1
    {
        public List<MonthDetails> MonthDetails { get; set; }


    }
    public class MonthDetails
    {
        public string MonthId { get; set; }
        public string MonthName { get; set; }
        public List<AttendanceDetails> AttendanceDetails { get; set; }

    }
    public class AttendanceDetails
    {
        public string AttendanceDate { get; set; }
        public string Day { get; set; }
        public string Status { get; set; }
        public string Month { get; set; }

    }

    public class Data
    {

        public string Title { get; set; }

        public List<MonthDetails> MonthDetails { get; set; }





    }
    public class SelfAttendanceDetails
    {
        public string AttendanceDate { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }


    }
    public class AttendaneceData
    {
        public List<SelfAttendanceDetails> AttendanceDetails { get; set; }


    }
    public class SelfAttendance
    {
        public List<AttendaneceData> AttendanceList { get; set; }

        public string Pk_TeacherId { get; set; }

        public string Status { get; set; }
        public string FromDate { get; set; }

        public string ToDate { get; set; }



        public DataSet GetAttendanceDetailsNew()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@FromDate",FromDate ),
                                     new SqlParameter("@ToDate",ToDate ),
                                      new SqlParameter("@Pk_TeacherId",Pk_TeacherId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("AttendanceReport", para);
            return ds;
        }

    }



    public class HomeWork
    {
        public List<HomeWorkData> lsthomeworkDetails { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public DataSet GetHomeworkForParent()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@StudentId",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetHomeworkForParent", para);
            return ds;
        }

    }
    public class HomeWorkData
    {
        public string Title { get; set; }
        public List<HomeWorkDetails> HomeWorkDetails { get; set; }


    }
    public class HomeWorkDetails
    {

        public string SectionName { get; set; }
        public string HomeworkFile { get; set; }
        public string HomeworkText { get; set; }
        public string Subject { get; set; }
        public string Pk_HomeworkID { get; set; }
        public string ClassName { get; set; }
        public string HomeworkDate { get; set; }
    }

    public class GetClass
    {
        public List<ClassData> lstclassdetails { get; set; }
        public string PK_TeacherID { get; set; }
        public string Status { get; set; }
        public DataSet GetClassList()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@TeacherID",PK_TeacherID ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetClassList", para);
            return ds;
        }
    }
    public class ClassData
    {
        public string Title { get; set; }
        public List<ClassDetails> ClassDetails { get; set; }


    }
    public class ClassDetails
    {

        public string PK_ClassID { get; set; }
        public string ClassName { get; set; }

    }


    public class GetSection
    {
        public List<SectionData> lstsectiondetails { get; set; }
        public string PK_TeacherID { get; set; }
        public string Fk_ClassID { get; set; }
        public string Status { get; set; }
        public DataSet GetSectionByClass()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@Fk_ClassID",Fk_ClassID),
                                      new SqlParameter("@TeacherID",PK_TeacherID),

                                  };
            DataSet ds = Connection.ExecuteQuery("GetSectionByClass", para);
            return ds;
        }
    }
    public class SectionData
    {
        public string Title { get; set; }
        public List<SectionDetails> SectionDetails { get; set; }


    }
    public class SectionDetails
    {

        public string PK_SectionId { get; set; }
        public string SectionName { get; set; }

    }

    public class GetSubject
    {
        public List<SubjectData> lstSubjectdetails { get; set; }
        public string PK_TeacherID { get; set; }
        public string PK_ClassID { get; set; }
        public string Fk_SectionID { get; set; }
        public string Status { get; set; }
        public DataSet GetSubjectNameBySection()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@Fk_ClassId",PK_ClassID),
                                      new SqlParameter("@Fk_SectionId",Fk_SectionID),
                                      new SqlParameter("@FK_TeacherID",PK_TeacherID),


                                  };
            DataSet ds = Connection.ExecuteQuery("GetSubjectNameByTeacher", para);
            return ds;
        }
    }
    public class SubjectData
    {
        public string Title { get; set; }
        public List<SubjectDetails> SubjectDetails { get; set; }


    }
    public class SubjectDetails
    {

        public string Fk_SubjectID { get; set; }
        public string SubjectName { get; set; }

    }

    public class TeacherHomeWork
    {
        public List<HomeWorkData> lsthomeworkDetails { get; set; }
        public string FromDate { get; set; }

        public string PK_TeacherID { get; set; }

        public string ToDate { get; set; }

        public string Status { get; set; }
        public DataSet HomeworkList()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@FromDate",FromDate),
                                      new SqlParameter("@ToDate",ToDate),
                                       new SqlParameter("@HomeworkBy","Teacher"),
                                      new SqlParameter("@AddedBy",PK_TeacherID),


                               };
            DataSet ds = Connection.ExecuteQuery("HomeWorkList", para);
            return ds;
        }

    }

    public class DeleteHomeWOrk
    {
        public string Status { get; set; }
        public string Pk_HomeworkID { get; set; }

        public string Pk_TeacherID { get; set; }
        public string ErrorMessage { get; set; }

        public DataSet DeleteHomework()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@Pk_HomeworkID",Pk_HomeworkID),
                                      new SqlParameter("@DeletedBy",Pk_TeacherID),



                               };
            DataSet ds = Connection.ExecuteQuery("DeleteHomeworkByTeacher", para);
            return ds;
        }
    }



    public class Sylabus
    {
        public List<SylabusData> lstSylabusDetails { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public DataSet GetSylabusDetails()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@StudentId",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetSyllabusForParent", para);
            return ds;
        }

    }
    public class SylabusData
    {
        public string Title { get; set; }
        public List<SylabusDetails> SylabusDetails { get; set; }


    }
    public class SylabusDetails
    {

        public string Syllabus { get; set; }


    }



    public class FeeReport
    {
        public List<FeeReportData> lstfeedetails { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public DataSet GetFeeReport()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_StudentId",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetFeeReport", para);
            return ds;
        }
    }
    public class FeeReportData
    {
        public string Title { get; set; }
        public List<FeeReportDetails> FeeReportDetails { get; set; }


    }
    public class FeeReportDetails
    {
        public string Amount { get; set; }
        public string BankDetails { get; set; }
        public string MonthName { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public string ReceiptNo { get; set; }



    }





    public class TimeTable
    {
        public List<TimeTableData> lsttimetabledetails { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public DataSet GetTimeTableForParent()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@StudentId",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetTimeTableForParent", para);
            return ds;
        }

    }
    public class TimeTableData
    {
        public string Title { get; set; }
        public List<TimeTableDetails> TimeTableDetails { get; set; }


    }
    public class TimeTableDetails
    {

        public string TimeTable { get; set; }


    }


    public class Leave1
    {
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string Pk_StudentId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Reason { get; set; }


        public DataSet SaveLeave()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@Pk_StudentID",Pk_StudentId),
                                   new SqlParameter("@FromDate",FromDate),
                                    new SqlParameter("@ToDate",ToDate),
                                   new SqlParameter("@Reason",Reason),
                              };
            DataSet ds = Connection.ExecuteQuery("ApplyLeaveForStudentByParent", para);
            return ds;

        }
    }


    public class ApplyLeave
    {
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string Pk_TeacherId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Reason { get; set; }


        public DataSet SaveLeave()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@FK_TeacherID",Pk_TeacherId),
                                   new SqlParameter("@FromDate",FromDate),
                                    new SqlParameter("@ToDate",ToDate),
                                   new SqlParameter("@EmployeeRemark",Reason),
                              };
            DataSet ds = Connection.ExecuteQuery("LeaveApplicationByTeacher", para);
            return ds;

        }
    }

    public class ApproveLeave
    {
        public string Pk_LeaveId { get; set; }
        public string ApprovedBy { get; set; }

        public string Status { get; set; }
    }

    public class LeaveList
    {
        public List<LeaveListData> lstleavelist { get; set; }
        public string Pk_StudentId { get; set; }

        public string FK_TeacherID { get; set; }
        public string Status { get; set; }
        public DataSet StudentLeaveApplicationList()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@FK_StudentID",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("StudentLeaveApplicationList", para);
            return ds;
        }
        public DataSet TeacherStudentsLeaveApplication()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@FK_TeacherID",FK_TeacherID ),
                                  };
            DataSet ds = Connection.ExecuteQuery("TeacherStudentsLeaveApplication", para);
            return ds;
        }
    }
    public class LeaveListData
    {
        public string Title { get; set; }
        public List<LeaveListDetails> LeaveListDetails { get; set; }


    }
    public class LeaveListDetails
    {

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string PK_StdntLeaveID { get; set; }
    }



    public class LeaveListForTeacher
    {
        public List<LeaveListData> lstleavelist { get; set; }
        public string Pk_TeacherId { get; set; }
        public string Status { get; set; }
        public DataSet TeacherLeaveApplicationList()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Teacherid",Pk_TeacherId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("TeacherLeaveList", para);
            return ds;
        }

    }

    public class ApproveLeaveForStudent
    {
        public string PK_StdntLeaveID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ErrorMessage { get; set; }
        public string Pk_TeacherId { get; set; }
        public DataSet ApproveLeave()
        {
            SqlParameter[] para ={
                                   new SqlParameter("@PK_StdntLeaveID",PK_StdntLeaveID),
                                   new SqlParameter("@Description",Description),
                                   new SqlParameter("@UpdatedBy",Pk_TeacherId),
                                   new SqlParameter("@Status",Status),

                               };
            DataSet ds = Connection.ExecuteQuery("UpdateStudentLeaveApplication", para);
            return ds;
        }
    }



    public class ChangePas
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string Pk_ParentId { get; set; }
        public string ErrorMessage { get; set; }
        public string Status { get; set; }

        public DataSet ChangeParentPassword()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@OldPassword",OldPassword),
                                   new SqlParameter("@NewPassword",NewPassword),
                                    new SqlParameter("@Pk_ParentID",Pk_ParentId),
                                   new SqlParameter("@UpdatedBy",Pk_ParentId),
                              };
            DataSet ds = Connection.ExecuteQuery("ChangeParentPassword", para);
            return ds;

        }
    }




    public class BirthDay
    {
        public List<BirthDayData> lstBirthDaylist { get; set; }

        public string Status { get; set; }
        public DataSet GetBirthday()
        {

            DataSet ds = Connection.ExecuteQuery("GetBirthday");
            return ds;
        }

    }
    public class BirthDayData
    {
        public string Title { get; set; }
        public List<BirthDayDetails> BirthDayDetails { get; set; }


    }
    public class BirthDayDetails
    {

        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string StudentPhoto { get; set; }
    }




    public class Notice
    {
        public List<NoticeData> lstNoticelist { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public DataSet GetNotice()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@FK_StudentID",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetNotice", para);
            return ds;
        }

    }
    public class NoticeData
    {
        public string Title { get; set; }
        public List<NoticeDetails> NoticeDetails { get; set; }


    }
    public class NoticeDetails
    {
        public string NoticeDate { get; set; }
        public string NoticeName { get; set; }
        public string PK_NoticeId { get; set; }

    }

    public class AddNotice
    {
        public string PK_ClassID { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string PK_SectionId { get; set; }
        public string Notice { get; set; }
        public string AddedBy { get; set; }
        public DataSet SaveNotice()
        {
            SqlParameter[] para =
             {
                new SqlParameter("@AddedBy",AddedBy),
                new SqlParameter("@Fk_ClassId",PK_ClassID),
                new SqlParameter("@FK_SectionId",PK_SectionId),
                new SqlParameter("@NoticeName",Notice),
                    new SqlParameter("@NoticeBy","Teacher"),
            };
            DataSet ds = Connection.ExecuteQuery("SaveNoticeMaster", para);
            return ds;
        }

    }


    public class NoticeList
    {
        public List<NoticeData> lstNoticeList { get; set; }
        public string Pk_TeacherId { get; set; }
        public string Status { get; set; }
        public DataSet GetNotice()
        {
            SqlParameter[] para =
           {

                new SqlParameter("@AddedBy",Pk_TeacherId),

            };
            DataSet ds = Connection.ExecuteQuery("GetNoticeList", para);
            return ds;
        }

    }

    public class DeleteNotice
    {
        public string Status { get; set; }
        public string PK_NoticeId { get; set; }

        public string Pk_TeacherId { get; set; }


        public string ErrorMessage { get; set; }

        public DataSet DeleteNoticeData()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@DeletedBy",Pk_TeacherId),
                 new SqlParameter("@PK_NoticeId",PK_NoticeId)
            };
            DataSet ds = Connection.ExecuteQuery("DeleteNotice", para);
            return ds;
        }
    }


    public class Banner
    {
        public List<BannerData> lstBannerlist { get; set; }

        public string Status { get; set; }
        public DataSet GetBanner()
        {

            DataSet ds = Connection.ExecuteQuery("GetBanner");
            return ds;
        }

    }
    public class BannerData
    {
        public string Title { get; set; }
        public List<BannerDetails> BannerDetails { get; set; }


    }
    public class BannerDetails
    {

        public string BannerName { get; set; }

    }



    public class ComplainBox
    {
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string Pk_StudentId { get; set; }

        public string Complain { get; set; }


        public DataSet SaveComplain()
        {
            SqlParameter[] para ={

                                    new SqlParameter("@Fk_UserId",Pk_StudentId),
                                    new SqlParameter("@Message",Complain),
                                    new SqlParameter("@AddedBy",Pk_StudentId),
                                    new SqlParameter("@MessageBy","Parent"),
                              };
            DataSet ds = Connection.ExecuteQuery("InsertMessage", para);
            return ds;

        }
    }



    public class ComplainList
    {
        public List<ComplainListData> lstComplainList { get; set; }
        public string Pk_StudentId { get; set; }
        public string Status { get; set; }
        public string Fk_SectionId { get; set; }
        public string Fk_ClassId { get; set; }
        public DataSet GetComplain()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Fk_StudentId",Pk_StudentId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetComplain", para);
            return ds;
        }
        public DataSet GetComplainForTecaher()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Fk_ClassId",Fk_ClassId ),
                                     new SqlParameter("@Fk_SectionId",Fk_SectionId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetComplainForTeacher", para);
            return ds;
        }
    }
    public class ComplainListData
    {
        public string Title { get; set; }
        public List<ComplainListDetails> ComplainListDetails { get; set; }


    }
    public class ComplainListDetails
    {

        public string ComplainDate { get; set; }
        public string Complain { get; set; }
        public string ReplyDate { get; set; }
        public string Reply { get; set; }
        public string Pk_MessageId { get; set; }
    }

    public class ReplyComplain
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }

        public string Fk_TeacherId { get; set; }
        public string Pk_MessageId { get; set; }
        public DataSet ReplyComplainByTeacher()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Message",Message ),
                                     new SqlParameter("@AddedBy",Fk_TeacherId ),
                                     new SqlParameter("@MessageBy","Teacher" ),
                                     new SqlParameter("@Fk_MessageId",Pk_MessageId ),

                                  };
            DataSet ds = Connection.ExecuteQuery("InsertMessage", para);
            return ds;
        }
    }



    public class DeviceDetails
    {
        public string ErrorMessage { get; set; }

        public string Status { get; set; }
        public string FireBaseId { get; set; }
        public string DeviceId { get; set; }
        public DataSet SaveDeviceDetails()
        {
            SqlParameter[] para ={
                                    new SqlParameter ("@DeviceId",DeviceId),
                                    new SqlParameter("@FireBaseId",FireBaseId),
                                };
            DataSet ds = Connection.ExecuteQuery("SaveDeviceDetails", para);
            return ds;
        }

    }




    public class Logout
    {

        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string LoginId { get; set; }

        public string DeviceId { get; set; }


        public DataSet UpdateDeviceId()
        {
            SqlParameter[] para ={new SqlParameter ("@DeviceId",DeviceId),
                                new SqlParameter("@LoginId",LoginId),
            };
            DataSet ds = Connection.ExecuteQuery("UpdateDeviceId", para);
            return ds;
        }


    }


    public class TeacherLogin
    {
        public string Password { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string LoginId { get; set; }
        public string PK_TeacherID { get; set; }
        public string ImagePath { get; set; }
        public string DeviceId { get; set; }
        public string FireBaseId { get; set; }

        public string TeacherName { get; set; }
        public string IsClassTeacher { get; set; }
        public string Fk_ClassId { get; set; }
        public string Fk_SectionId { get; set; }

        public DataSet TeacherLoginAction()
        {
            SqlParameter[] para ={new SqlParameter ("@LoginId",LoginId),
                                new SqlParameter("@Password",Password),
             new SqlParameter("@UserType","3")};
            DataSet ds = Connection.ExecuteQuery("Login", para);
            return ds;
        }
        public DataSet SaveDeviceDetails()
        {
            SqlParameter[] para ={
                                    new SqlParameter ("@DeviceId",DeviceId),
                                    new SqlParameter("@FireBaseId",FireBaseId),
                                    new SqlParameter("@AddedBy",PK_TeacherID),
                                };
            DataSet ds = Connection.ExecuteQuery("SaveTeacherDeviceDetails", para);
            return ds;
        }
    }




    public class StudentList
    {
        public List<StudentListData> lstStudentList { get; set; }
        public string Pk_StudentId { get; set; }

        public string Pk_ClassId { get; set; }

        public string Pk_SectionId { get; set; }
        public string StudentName { get; set; }

        public string MobileNo { get; set; }
        public string Status { get; set; }
        public DataSet GetStudentList()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Fk_ClassID",Pk_ClassId ),
                                     new SqlParameter("@Fk_SectionID",Pk_SectionId ),
                                  };
            DataSet ds = Connection.ExecuteQuery("GetStudentList", para);
            return ds;
        }

    }
    public class StudentListData
    {
        public string Title { get; set; }
        public List<StudentListDetails> StudentListDetails { get; set; }


    }
    public class StudentListDetails
    {

        public string StudentName { get; set; }
        public string Mobile { get; set; }
        public string Pk_StudentID { get; set; }
    }




    public class MarkAttendance
    {
        public string ErrorMessage { get; set; }
        public string Status { get; set; }
        public string AttendanceDate { get; set; }
        public string Pk_ClassId { get; set; }
        public string Pk_SectionId { get; set; }
        public List<MarkAttendanceData> lstMarkAttendance { get; set; }
        public DataTable dsStudentAttendance { get; set; }
        public string AddedBy { get; set; }
        public DataSet SaveAttendance()
        {
            SqlParameter[] para ={
                                   new SqlParameter("@StudentAttendance",dsStudentAttendance),
                                   new SqlParameter("@FK_ClassId",Pk_ClassId),
                                   new SqlParameter("@FK_SectionId",Pk_SectionId),
                                   new SqlParameter("@AttendanceDate",AttendanceDate),
                                   new SqlParameter("@AddedBy",AddedBy),
                                   new SqlParameter("@AttendanceBy","Teacher"),

                               };
            DataSet ds = Connection.ExecuteQuery("InsertStudentAttendance", para);
            return ds;
        }
    }
    public class MarkAttendanceData
    {

        public List<MarkAttendancDetails> MarkAttendancDetails { get; set; }


    }
    public class MarkAttendancDetails
    {
        public string StudentName { get; set; }
        public string Pk_StudentID { get; set; }
        public string Mobile { get; set; }
        public string Status { get; set; }

    }



    public class ExamType
    {
        public List<ExamTypeData> lstexamdetails { get; set; }
        public string Status { get; set; }

        public DataSet GetExamType()
        {

            DataSet ds = Connection.ExecuteQuery("GetExamtype");
            return ds;

        }
    }
    public class ExamTypeData
    {
        public string Title { get; set; }
        public List<ExamDetails> ExamDetails { get; set; }


    }
    public class ExamDetails
    {

        public string ExamTypeName { get; set; }
        public string Pk_ExamTypeId { get; set; }

    }


    public class StudentMarks
    {
        public string ErrorMessage { get; set; }
        public string Status { get; set; }
        public string Fk_ExamTypeId { get; set; }
        public string Fk_SubjectId { get; set; }

        public List<StudentMarksData> lstMarks { get; set; }
        public DataTable dsStudentAttendance { get; set; }
        public string AddedBy { get; set; }
        public DataSet InsertStudentSubjectMarks()
        {
            SqlParameter[] para ={
                                   new SqlParameter("@StudentAttendance",dsStudentAttendance),
                                   new SqlParameter("@Fk_SubjectId",Fk_SubjectId),
                                   new SqlParameter("@Fk_ExamTypeId",Fk_ExamTypeId),

                                   new SqlParameter("@AddedBy",AddedBy),


                               };
            DataSet ds = Connection.ExecuteQuery("InsertStudentSubjectMarks", para);
            return ds;
        }
    }
    public class StudentMarksData
    {

        public List<StudentMarksDetails> StudentMarksDetails { get; set; }


    }
    public class StudentMarksDetails
    {

        public string Pk_StudentID { get; set; }
        public string ObtainMarks { get; set; }
        public string MaximumMarks { get; set; }

    }



    public class MarkSheet
    {
        public string Status { get; set; }

        public List<Session> lstsessiondetails { get; set; }

        public DataSet SessionList()
        {
            DataSet ds = Connection.ExecuteQuery("GetSession");
            return ds;
        }
    }
    public class Session
    {
        public string Title { get; set; }
        public List<SessionDetails> SessionDetails { get; set; }


    }
    public class SessionDetails
    {

        public string SessionName { get; set; }
        public string Pk_SessionId { get; set; }

    }

    public class GetMarks
    {
        public string Status { get; set; }
        public string Fk_SectionId { get; set; }
        public string Fk_ClassId { get; set; }
        public string Pk_StudentID { get; set; }
        public string ExamTypeName { get; set; }
        public string Pk_SessionId { get; set; }
        public string Fk_ParentId { get; set; }
        public List<MarksData> lstmarksdetails { get; set; }
        public DataSet StudentMarksheet()
        {
            SqlParameter[] para ={
                                    new SqlParameter("@Fk_SectionId",Fk_SectionId),
                                    new SqlParameter("@Fk_ClassId",Fk_ClassId),
                                    new SqlParameter("@Fk_StudentId",Pk_StudentID),
                                    new SqlParameter("@Fk_ExamTypeId",ExamTypeName),
                                    new SqlParameter("@Fk_ParentId",Fk_ParentId),
                                     new SqlParameter("@Fk_SessionId",Pk_SessionId),

                                };
            DataSet ds = Connection.ExecuteQuery("Marksheet", para);
            return ds;
        }

        public DataSet StudentMarksheetForParent()
        {
            SqlParameter[] para ={
                                    new SqlParameter("@Fk_StudentId",Pk_StudentID),
                                    new SqlParameter("@Fk_ExamTypeId",ExamTypeName),

                                };
            DataSet ds = Connection.ExecuteQuery("MarksheetForParent", para);
            return ds;
        }
    }
    public class MarksData
    {
        public string Title { get; set; }
        public List<MarksDetails> MarksDetails { get; set; }
    }
    public class MarksDetails
    {
        public string Fk_SectionId { get; set; }
        public string Fk_ClassId { get; set; }
        public string MaximumMarks { get; set; }
        public string ObtainMarks { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string StudentName { get; set; }
        public string ExamTypeName { get; set; }
        public string Fk_StudentId { get; set; }
        public string Fk_ExamTypeId { get; set; }
        public string SubjectName { get; set; }
    }
    public class PrintMarkSheet
    {
        public string Status { get; set; }
        public string Fk_SectionID { get; set; }
        public string Fk_ClassID { get; set; }
        public string Pk_StudentID { get; set; }
        public string Pk_ExamTypeId { get; set; }

        public string StudentName { get; set; }
        public string ParentName { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ExamTypeName { get; set; }

        public string SessionName { get; set; }
        public string RegistrationNo { get; set; }
        public List<SubjectMarksData> lstsubjectmarksdetails { get; set; }
        public DataSet PrintMarksheet()
        {
            SqlParameter[] para ={
                                    new SqlParameter("@Fk_SectionId",Fk_SectionID),
                                    new SqlParameter("@Fk_ClassId",Fk_ClassID),
                                    new SqlParameter("@Fk_StudentId",Pk_StudentID),
                                    new SqlParameter("@Fk_ExamTypeId",Pk_ExamTypeId),
                                };
            DataSet ds = Connection.ExecuteQuery("PrintMarksheet", para);
            return ds;
        }

        public DataSet PrintMarksheetForParent()
        {
            SqlParameter[] para ={
                                    new SqlParameter("@Fk_StudentId",Pk_StudentID),
                                    new SqlParameter("@Fk_ExamTypeId",Pk_ExamTypeId),
                                };
            DataSet ds = Connection.ExecuteQuery("PrintMarksheetForParent", para);
            return ds;
        }
    }
    public class SubjectMarksData
    {
        public string Title { get; set; }
        public List<SubjectMarksDetails> listSubjectMarksDetails { get; set; }
    }
    public class SubjectMarksDetails
    {

        public string MaximumMarks { get; set; }
        public string ObtainMarks { get; set; }

        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

    }







}