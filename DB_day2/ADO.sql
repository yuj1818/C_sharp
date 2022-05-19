create or replace function getDept(deptno in number)
return sys_refcursor is
    refcur_ret sys_refcursor;
begin
    open refcur_ret for 'select * from emp where deptno = :1' using deptno;
    return refcur_ret;
end getDept;

variable a refcursor;
exec :a := getDept(10);
print a;