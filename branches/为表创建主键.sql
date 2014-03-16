

declare @t varchar(100)
declare @sql nvarchar(1000)
declare cur cursor for
select name from sysobjects where xtype='U'
open cur--打开游标
fetch next from cur into @t--把提取操作的列数据放到局部变量中
while(@@fetch_status=0)--返回被 FETCH 语句执行的最后游标的状态，而不是任何当前被连接打开的游标的状态。
begin
 --print @t
 --IF NOT EXISTS (select * from sysobjects where parent_obj=@t  and xtype='PK')
 set @sql='IF NOT EXISTS (select * from sysobjects where parent_obj=object_id(N'''+@t+''')  and xtype=''PK'') begin alter table '+@t+' add Id nvarchar(20) not null ;alter table '+@t+' add constraint '+@t+'_id primary key(Id) end'
 print @sql
 
--提前下一位信息
fetch next from cur into @t
end
close cur--关闭游标
deallocate cur--删除游标