use  DB09TMS101_1718

create table c_123(C_id int identity(1,1) primary key, C_Name varchar(40),Gender varchar(10),
        DOB datetime,C_Number bigint,City varchar(40));

		create proc sp_addcustomer03
		@cid int out,@cn varchar(40),@g varchar(10),@dob datetime,@cno bigint,@city varchar(40)

		as
		begin
		insert into  c_123 values(@cn,@g,@dob,@cno,@city)
		set @cid=@@IDENTITY
		end;


		select * from c_123 

		create table a_123(acc_id int identity(500,1) primary key,C_id int foreign key references c_123, amnt money,
		acc_type varchar(20),acc_start_date date, acc_status varchar(20));
  
		
		create proc sp_addaccount031
		@acc_id int out, @cid int,@amnt money,@acc_type varchar(20)

		as
		begin
		insert into a_123 values (@cid,@amnt,@acc_type,GETDATE(),'ACTIVE')
		set @acc_id=@@IDENTITY
		end;

		select * from a_123


		create proc sp_viewcustomer123
		as
         begin
            select * from c_123
      end;

create proc sp_viewaccount123
as
begin
select * from a_123
end;

create proc sp_viewcustomerbyid123
@cid int
as
begin
select * from c_123 where C_id=@cid;
end;

create proc sp_deletecustomer_03
@cid int
as
begin
delete from  a_123 where 
a_123.C_id=@cid  ;
delete from  c_123  where 
c_123.C_id=@cid  ;

end


alter proc sp_deaccustomer_03
@cid int
as
begin
update a_123 set acc_status='INACTIVE'where C_id=@cid
end

create proc sp_joincust
as
begin
select amnt,acc_start_date,acc_type ,acc_status, C_Name from a_123 join c_123 on a_123.C_id = c_123.C_id; 
end;

		
		 
