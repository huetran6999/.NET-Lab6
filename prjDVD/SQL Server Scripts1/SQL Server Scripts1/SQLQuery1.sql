Create Database DVDLibrary 
Use DVDLibrary 
Create Table DVDLibrary( 
 DVDCodeNo int Primary Key, 
 DVDTitle nvarchar(100) Not Null, 
 [Language] nvarchar(20) Not Null, 
 SubTitle bit Not Null, 
 Price Money Not Null 
)
CHECK_POLICY = OFF
sp_changedbowner mylogin 

select * from DVDLibrary;