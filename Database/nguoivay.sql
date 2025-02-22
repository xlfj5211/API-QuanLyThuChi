
ALTER PROC [dbo].[SP_XemNguoiVay]
AS
BEGIN
	SELECT *FROM dbo.NguoiVay
END
ALTER PROC [dbo].[SP_ThemNguoiVay]( @ten NVARCHAR(50), @sdt INT)
AS
BEGIN
	INSERT INTO dbo.NguoiVay
	        (  Ten, SDT )
	VALUES  (  -- id - nchar(10)
	          @ten, -- Ten - nvarchar(50)
	          @sdt  -- SDT - int
	          )
END

ALTER PROC [dbo].[SP_SuaNguoiVay](@ma int, @ten NVARCHAR(50), @sdt INT)
AS
BEGIN
	UPDATE dbo.NguoiVay 
	SET  Ten = @ten , SDT = @sdt
	WHERE id = @ma
END


create proc [dbo].[SP_XoaNguoiVay](@id int)
as
begin
	Delete dbo.NguoiVay where id = @id
end
GO

create proc [dbo].[SP_TimKiemNguoiVay](@id int)
as
begin
	SELECT id,Ten,SDT
	FROM dbo.NguoiVay
	WHERE id = @id
END
