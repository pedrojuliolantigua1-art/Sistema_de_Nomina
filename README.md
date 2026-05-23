# Proyecto de Sistema de Nomina

Este proyecto lo realice en C# en una aplicacion de consola. El sistema permite registrar y actualizar diferentes tipos de empleados y calcular sus pagos semanales.

Tipos de empleados: Empleado Asalariado, Empleado por horas, Empleado por Comision, Empleado Asalariado por Comision.

## **Funcionalidaes**
- Agregar empleados
- Actualizar los datos de los empleados
- Mostrar reporte semanal
- Calcular el pago a cada tipo de empleado.

## **Estructura**

## **Clases Abstracta Empleado**
- Contiene los datos en comun apellido paterno y Numero de seguro social
- Tiene los metodos abstractos; PagoEmpleado() y Actualizar()

## **Clases derivadas**
- Empleado_Asalariado --> hereda de empleado
- Empleado_Por_Horas  --> hereda de empleado
- Empleados_Por_Comision   --> hereda de empleado
- y Empleado_Asalariado_Por_Comision --> que hereda de Empleado_Por_Comision

El proyecto utiliza herencia multinivel, ya que la clase Empleado_Asalariado_Por_Comision hereda de Empleado_Por_Comision,
y esta a su vez hereda de la clase abstracta Empleado.


## **Menu Principal**

<img width="600" height="314" alt="image" src="https://github.com/user-attachments/assets/d5db75ff-2205-4d06-bac8-ffbbe109a7d9" />

### Opcion 1 agregar empleado asalariado  
<img width="382" height="113" alt="image" src="https://github.com/user-attachments/assets/3e06cfa9-a194-40b2-804d-1db93cfcf9c4" />

### Opcion 2 agregar empleado por Horas
<img width="418" height="107" alt="image" src="https://github.com/user-attachments/assets/94e4b3d8-34c0-4742-bcad-4a949db65498" />

### Opcion 3  Agregar empleado por Comision
<img width="375" height="135" alt="image" src="https://github.com/user-attachments/assets/7c2682cf-2643-4e5f-9529-a68149c1cbe2" />

### Opcion 4 Agregar empleado Asalariado por Comision
<img width="399" height="143" alt="image" src="https://github.com/user-attachments/assets/c2a2e14d-00c3-4162-8ffb-b9ed6182f9bd" />

### Opcion 5 Mostrar el reportes de todos los empleados, donde se visualiza toda su informacion y su pago semanal
<img width="646" height="934" alt="image" src="https://github.com/user-attachments/assets/8a908ca3-67fa-4b01-b986-3d54d84b090a" />


### Opcion 6 Actualizar un empleado
primero se busca por el apellido paterno o por el numero de seguro social, que son las unicas caracteristicas que tienen en comun, todos los empleados y luego se actualizan sus datos para recalcular nuevamente la nomina semanal.
<img width="505" height="224" alt="image" src="https://github.com/user-attachments/assets/eebd6739-67c1-4f4c-989c-9ca6ed6f9631" />

# Aqui ya se visualiza en el reporte a el empleado actualizado
<img width="517" height="182" alt="image" src="https://github.com/user-attachments/assets/42adb123-5931-4cd4-846d-a130a1ea29b6" />










