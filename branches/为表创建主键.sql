

declare @t varchar(100)
declare @sql nvarchar(1000)
declare cur cursor for
select name from sysobjects where xtype='U'
open cur--���α�
fetch next from cur into @t--����ȡ�����������ݷŵ��ֲ�������
while(@@fetch_status=0)--���ر� FETCH ���ִ�е�����α��״̬���������κε�ǰ�����Ӵ򿪵��α��״̬��
begin
 --print @t
 --IF NOT EXISTS (select * from sysobjects where parent_obj=@t  and xtype='PK')
 set @sql='IF NOT EXISTS (select * from sysobjects where parent_obj=object_id(N'''+@t+''')  and xtype=''PK'') begin alter table '+@t+' add Id nvarchar(20) not null ;alter table '+@t+' add constraint '+@t+'_id primary key(Id) end'
 print @sql
 
--��ǰ��һλ��Ϣ
fetch next from cur into @t
end
close cur--�ر��α�
deallocate cur--ɾ���α�