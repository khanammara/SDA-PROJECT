using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TMS
{
    class TMSQuerry
    {
        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public string constring = "Data Source=BINARY-AXIS;Initial Catalog=TMSystem;Integrated Security=True";





        //*******************************************************************************************************
        //Reserve Ticket Querry
        public void ReserveTicket(string distributer , string transport , string from, string to, string stop, string date)
        {



            conn = new SqlConnection(constring);
            conn.Open();
            if (distributer != "" && transport != "" && from != "" && to != "" && stop != "" && date != "")
            {
                string q = "Insert into BusTicket (DistributerID, TransportCardNo, [From], [To],  StopID, [TicketDate]) values ('" + distributer.ToString() + "','" + transport.ToString() + "','" + from.ToString() + "','" + to.ToString() + "','" + stop.ToString() + "','" + date.ToString() + "')";
                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();
                DialogResult DDR = MessageBox.Show("Ticket Reserved Successfully!", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                
            }


        }


        //*******************************************************************************************************
        //TransportCard Querry
        public void AddTransportCard(string customer,string number,string age,string address,string card)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (customer != "" && number != "" && age != "" && address != "" && card != "")
            {
                string q = "Insert into TransportCard (TransportCardNo) values ('" + card.ToString() + "')";
                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();
                 q = "Insert into C_Transport (CustomerID,CustomerName, ContactNumber, Age, C_Address, TransportCardNo) values ( 1 ,'" + customer.ToString() + "','" + number.ToString() + "','" + age.ToString() + "','" + address.ToString() + "','" + card.ToString() + "')";
                cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();
                 
                DialogResult DDR = MessageBox.Show("Transport Card Added Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }

        }
     
        public void UpdateTransportCard(string customer, string number, string age, string address, string card)
        {
            if (customer != "" && number != "" && age != "" && address != "" && card != "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update C_Transport set CustomerName=@customer_name,ContactNumber=@contact_number,Age=@age,C_Address=@c_address,TransportCardNo=@Transport_cardno where TransportCardNo=@transport_cardno", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@customer_name", customer);
                cm.Parameters.AddWithValue("@contact_number", number);
                cm.Parameters.AddWithValue("@age", age);
                cm.Parameters.AddWithValue("@c_address", address);
                cm.Parameters.AddWithValue("@transport_cardno", card);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }

        }



        public void DeleteTransportCard(string card)
        {
             conn = new SqlConnection(constring);
            if (card != "")
            {
                cm = new SqlCommand("Delete C_Transport where TransportCardNo=@transport_cardno", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@transport_cardno", card);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }






        //*******************************************************************************************************
        //Routes Record Querry
        public void UpdateRoutesRecord(string fare, string stop)
        {
            
            if (fare != "" && stop != "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update BusStop set StopID=@stop_id,StopFare=@stop_fare where StopID=@stop_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@stop_id", stop);
                cm.Parameters.AddWithValue("@stop_fare", fare);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }
        }







        //*******************************************************************************************************
        //Driver Record Querry
     
  public void AddDriver(string driver, string license, string contact, string salary, string driverid)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (driver != "" && license != "" && contact != "" && salary != "" && driverid != "")
            {
                
                string q = "Insert into Driver (EmployeeID, DriverID, DriverName, LicenseNo, ContactNo, Salary) values ( 125 ,'" + driverid.ToString() + "','" + driver.ToString() + "','" + license.ToString() + "','" + contact.ToString() + "','" + salary.ToString() + "')";
                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Driver Added Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }

        }


        
   public void UpdateDriverRecord(string driver, string license, string contact, string salary, string driverid)
        {

            if (driver != "" && license != "" && contact != "" && salary != "" && driverid != "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update Driver set DriverID=@driver_id,DriverName=@driver_name,LicenseNo=@lic,ContactNo=@num,Salary=@sal   where DriverID=@driver_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@driver_id", driverid);
                cm.Parameters.AddWithValue("@driver_name", driver);
                cm.Parameters.AddWithValue("@lic", license);
                cm.Parameters.AddWithValue("@num", contact);
                cm.Parameters.AddWithValue("@sal", salary);
     
                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }
        }



       

        public void DeleteDriverRecord(string driverid)
        {
            conn = new SqlConnection(constring);
            if (driverid != "")
            {
                cm = new SqlCommand("Delete Driver where DriverID=@driver_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@driver_id", driverid);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }







        //*******************************************************************************************************
        //Distributer Record Querry

        public void AddDistributer(string distributer, string contact, string salary, string distributerid)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (distributer != ""  && contact != "" && salary != "" && distributerid != "")
            {

                string q = "Insert into Distributer (EmployeeID, DistributerID, DistributerName, TD_ContactNo, TD_Salary) values ( 124 ,'" + distributerid.ToString() + "','" + distributer.ToString() + "','" + contact.ToString() + "','" + salary.ToString() + "')";
                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Driver Added Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
        }




        
   public void UpdateDistributerRecord(string distributer, string contact, string salary, string distributerid)
        {

            if (distributer != ""  && contact != "" && salary != "" && distributerid != "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update Distributer set DistributerID=@distributer_id,DistributerName=@distributer_name,TD_ContactNo=@num,TD_Salary=@sal   where distributerID=@distributer_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@distributer_id", distributerid);
                cm.Parameters.AddWithValue("@distributer_name", distributer);
                cm.Parameters.AddWithValue("@num", contact);
                cm.Parameters.AddWithValue("@sal", salary);

                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }
        }





        public void DeleteDistributerRecord(string distributerid)
        {
            conn = new SqlConnection(constring);
            if (distributerid != "")
            {
                cm = new SqlCommand("Delete Distributer where DistributerID=@distributer_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@distributer_id", distributerid);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }
















        //*******************************************************************************************************
        //Car Querry
        
        public void AddCar(string cartype, string rate, string carid, string categ)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (cartype != "" && rate != "" && carid != "" )
            {
                string q = "Insert into Car (VehicleID,CarID,CarType) values (22,'" + carid.ToString() + "','" + cartype.ToString() + "')";
                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();


                q = "Insert into CarType (CarID, Categories, Rate) values ('" + carid.ToString() + "','" + categ.ToString() + "','" + rate.ToString() + "')";
                cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Car Added Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
        }




             public void UpdateCarRecord(string carid, string rate)
        {

            if (carid != ""  && rate!= "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update CarType set CarID=@Car_id,Rate=@rate   where CarID=@car_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@Car_id", carid);
                cm.Parameters.AddWithValue("@Rate", rate);

                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }
        }


        public void DeleteCarRecord(string car_id)
        {
            conn = new SqlConnection(constring);
            if (car_id != "")
            {
                conn.Open();
                //cm = new SqlCommand("Delete Car where CarID=@car_id", conn);
                //cm.Parameters.AddWithValue("@Car_id", car_id);
                //cm.ExecuteNonQuery();
                cm = new SqlCommand("Delete CarType where CarID=@car_id", conn);  
                cm.Parameters.AddWithValue("@Car_id", car_id);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }






        //*******************************************************************************************************
        //Maintenance Querry



        public void AddMaintenance(string m_id,string manager,string vehicle,string type,string desc,string cost,string status)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (m_id != "" && manager != "" && vehicle != "" && type != "" && desc != "" && cost != "" && status != "")
            {
                string q = "Insert into Maintenance (MaintenaceID,ManagerID,VehicleID,VehicleType,M_Description,Cost,M_Status) " +
                    "values ('" + m_id.ToString() + "','" + manager.ToString() + "','" + vehicle.ToString() + "','" + type.ToString() + "','" + desc.ToString() + "','" + cost.ToString() + "','" + status.ToString() + "')";

                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Car Added Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
        }



        public void UpdateMaintenanceRecord(string m_id, string status)
        {

            if (m_id != "" && status != "")
            {
                conn = new SqlConnection(constring);


                cm = new SqlCommand("Update Maintenance set MaintenanceID=@M_id,M_Status=@Status where MaintenanceID=@M_id", conn);
                conn.Open();
                cm.Parameters.AddWithValue("@M_id", m_id);
                cm.Parameters.AddWithValue("@Status", status);

                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();

                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the Record to Update");
            }
        }




        //*******************************************************************************************************
        //PND Reservation Querry


        public void AddPNDReservation(string cname, string contact, string cartype, string from, string to, string date, string fare)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (cname != "" && contact != "" && cartype != "" && from != "" && to != "" && date != "" && fare != "")
            {
                string q = "Insert into C_PND (CustomerID,CustomerName,ContactNumber,Car_Type,[From],[To],ReserveDate,Fare) " +
                    "values (2,'" + cname.ToString() + "','" + contact.ToString() + "','" + cartype.ToString() + "','" + from.ToString() + "','" + to.ToString() + "','" + date.ToString() + "','" + fare.ToString() + "')";

                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Car Reserved Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
        }























       
 //*******************************************************************************************************
 //RAC Reservation Querry

  public void AddRACReservation(string cname, string contact, string cartype, string duration, string date, string rent)
        {

            conn = new SqlConnection(constring);
            conn.Open();
            if (cname != "" && contact != "" && cartype != "" && duration != "" && date != "" && rent != "")
            {
                string q = "Insert into C_RAC (CustomerID,CustomerName,ContactNumber,CarType,Duration,ReserveDate,Rent) " +
                    "values (3,'" + cname.ToString() + "','" + contact.ToString() + "','" + cartype.ToString() + "','" + duration.ToString() + "','" + date.ToString() + "','" + rent.ToString() + "')";

                SqlCommand cms = new SqlCommand(q, conn);
                cms.ExecuteNonQuery();

                DialogResult DDR = MessageBox.Show("Car Booked Successfully", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
            else
            {
                DialogResult DDR = MessageBox.Show("Please Enter Details.", "TMS", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            }
        }















        //*******************************************************************************************************
        //Login Querry
        public void LoginCheck(string user, string pass, string option)
        {
            conn = new SqlConnection(constring);
            conn.Open();

            if (option == "Manager")
            {
                try
                {
                    da = new SqlDataAdapter("SELECT * from [M_Login] where [UserName]='" + user + "' and [Password]='" + pass + "'", conn);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        ManagerDashboard form = new ManagerDashboard();
                        Login lf = new Login();
                        lf.Hide();
                        lf.FormClosed += new FormClosedEventHandler(delegate { lf.Close(); });
                        form.Show();

                    }
                    else
                    {
                        DialogResult DDR = MessageBox.Show("Incorrect Username or Password!", "TMS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }


                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else if (option == "Distributer")
            {
                try
                {
                    da = new SqlDataAdapter("SELECT * from [C_Login] where [UserName]='" + user + "' and [Password]='" + pass + "'", conn);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        DistributerDashboard form = new DistributerDashboard();
                        Login lf = new Login();
                        lf.Close();
                        lf.FormClosed += new FormClosedEventHandler(delegate { lf.Close(); });
                        form.Show();

                    }
                    else
                    {
                        DialogResult DDR = MessageBox.Show("Incorrect Username or Password!", "TMS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }


                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            else
            {
                DialogResult DDR = MessageBox.Show("Select User", "TMS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }


}
