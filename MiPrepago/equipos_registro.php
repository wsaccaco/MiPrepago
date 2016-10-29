<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="ico/favicon.ico">
    
    <title>SIME</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- MetisMenu CSS -->
    <link href="css/plugins/metisMenu/metisMenu.min.css" rel="stylesheet">

 	<!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">

	<!-- Custom CSS -->
    <link href="css/sb-admin-2.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="font-awesome-4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->


<script type="text/javascript"> 
    
	function modalon(){
		$('#myModal').modal("show");
	}
		


    </script>

</head>

<body>

<?php
	
require "libreria.php";	

$cn=fnconect();
	
	session_start();
  	$_session["id_personal"]=17;
  	$_session["nombres"]="Irwin Mendoza";
	
	$id_personal=$_session["id_personal"];

?>

    <div id="wrapper">

        <!-- Navigation -->
        
        <!-- Navigation -->
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.html"><img src="ico/favicon.ico">miprepago.com</a>
            </div>
            <!-- /.navbar-header -->

            <ul class="nav navbar-top-links navbar-right">
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-archive fa-fw"></i>  
                        <i class="fa fa-caret-down"></i>
                        
                    </a>
                    <ul class="dropdown-menu dropdown-messages">
<?php

$rs=fntop3visita($id_personal);
$rows=mysql_num_rows($rs);
for($i=0;$i<=($rows-1);$i++)
	{
	echo "<li>\n";
    echo "<a href='cita.php?c=".mysql_result($rs,$i,"id_cita")."'>\n";
    echo "<div>\n";
    echo "<strong> ".mysql_result($rs,$i,"nombres")."</strong>\n";
    echo "<span class='pull-right text-muted'>\n";
    echo "<em>".mysql_result($rs,$i,"fecha")."</em>\n";
    echo "</span>\n";
    echo "</div>\n";
    echo "<div> ".mysql_result($rs,$i,"motivo")."</div>\n";
    echo "</a>\n";
    echo "</li>\n";
    echo "<li class='divider'></li>\n";
	}

?>                        
                        
                        <li>
                            <a class="text-center" href="citas.php">
                                <strong>Ver todas las citas</strong>
                                <i class="fa fa-angle-right"></i>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-messages -->
                    
                </li>
                <!-- /.dropdown -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-tasks fa-fw"></i>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-tasks">
                    
<?php

$rs=fntop3proyecto($id_personal);
$rows=mysql_num_rows($rs);
for($i=0;$i<=($rows-1);$i++)
	{
		echo "<li>";
        echo "<a href='proyecto.php?r=".mysql_result($rs,$i,"id_proyecto")."'>";
        echo "<div>\n";
        echo "<p>\n";
		echo "<strong> ".mysql_result($rs,$i,"nombre")."</strong>\n";
		echo "<span class='pull-right text-muted'>".mysql_result($rs,$i,"prob")."%</span>\n";
		echo "</p>\n";
		echo "<div> ".mysql_result($rs,$i,"nombre1")." <i class='fa fa-money fa-fw'> </i><strong>".mysql_result($rs,$i,"monto")."</strong></div>\n";
		echo "<div class='progress progress-striped active'>\n";
		echo "<div class='progress-bar progress-bar-success' role='progressbar' aria-valuenow='40' aria-valuemin='0' aria-valuemax='100' style='width: ".mysql_result($rs,$i,"prob")."%'>\n";
		echo "<span class='sr-only'>40% Complete (success)</span>\n";
		echo "</div>\n";
		echo "</div>\n";
		echo "</div>\n";
		echo "</a>\n";
		echo "</li>\n";
		echo "<li class='divider'></li>\n";

		
	}


?>                    

                        <li>
                            <a class="text-center" href="#">
                                <strong>Ver todos mis proyectos</strong>
                                <i class="fa fa-angle-right"></i>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-tasks -->
                </li>
                <!-- /.dropdown -->
                
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-bell fa-fw"></i>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-alerts">
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-comment fa-fw"></i> 4 Nuevos Comentarios
                                    <span class="pull-right text-muted small">4 minutos</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-twitter fa-fw"></i> 3 Nuevo Seguidores
                                    <span class="pull-right text-muted small">12 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-envelope fa-fw"></i> Presupuestos enviados
                                    <span class="pull-right text-muted small">2 Dias</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-tasks fa-fw"></i> Nuevas Cotizaciones
                                    <span class="pull-right text-muted small">4 Dias</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-upload fa-fw"></i> 2 Citas Canceladas
                                    <span class="pull-right text-muted small">2 Meses</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a class="text-center" href="#">
                                <strong>Ver todas las Notofificaciones</strong>
                                <i class="fa fa-angle-right"></i>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-alerts -->
                </li>
                <!-- /.dropdown -->
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li><a href="#"><i class="fa fa-user fa-fw"></i> Perfil</a>
                        </li>
                        <li><a href="#"><i class="fa fa-gear fa-fw"></i> Administar</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="login.html"><i class="fa fa-sign-out fa-fw"></i> Salir</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->













            <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu">
                    
                        <li class="sidebar-search">
                            <div class="input-group custom-search-form">
                                <input type="text" class="form-control" placeholder="Buscar...">
                                <span class="input-group-btn">
                                <button class="btn btn-default" type="button">
                                    <i class="fa fa-search"></i>
                                </button>
                            </span>
                            </div>
                            <!-- /input-group -->
                        </li>
                        
                        
                        <li>
                            <a class="active" href="main.php"><i class="fa fa-dashboard fa-fw"></i> Dashboard</a>
                        </li>
                        <li>
                            <a href="empresas.php"><i class="fa fa-building fa-fw"></i> Empresas</a>
                        </li>
                        <li>
                            <a href="contactos.php"><i class="fa fa-male fa-fw"></i> Contactos</a>
                        </li>
                        <li>
                            <a href="citas.php"><i class="fa fa-archive fa-fw"></i> Citas</a>
                        </li>
                        <li>
                            <a href="proyectos.php"><i class="fa fa-tasks fa-fw"></i> Proyectos</a>
                        </li>
                        
                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->


        </nav>





        <div id="page-wrapper">
            <div class="row">
                <div class="col-lg-12">
                	<p>_</p>
                	
                    <h1 class="page-header">Equipos</h1>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->




            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Registro de Equipos
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">
                                    <form role="form" method="post" action="#">

                                        <div class="form-group">
                                         <div class="row">
                                         <div class="col-sm-10">
                                         
            <div class="form-group">
            <div class="row">
            <div class="col-sm-6">
              <input type="text" name="ruc" placeholder="Marca" value="" class="form-control">
            </div>
            </div>
            </div>
                                       

            <div class="form-group">
            <div class="row">
            <div class="col-sm-6">
              <input type="text" name="ruc2" placeholder="Modelo" value="" class="form-control">
            </div>
            </div>
            </div>        

            <div class="form-group">
            <div class="row">
            <div class="col-sm-6">
              <input type="text" name="ruc3" placeholder="Anio Fabricacion" value="" class="form-control">
            </div>
            </div>
            </div>   

            <div class="form-group">
            <div class="row">
            <button id="btnguardar" type="submit" class="btn btn-success">Guardar</button>
            </div>
            </div>   

                                          </div>
                                          </div>
                                          </div>
                                        
                                     </form>
                                 </div>
                             </div>
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
            
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Registro de Equipos
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="table-responsive">
                                <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                    <thead>
                                        <tr>
                                            <th class="center">Marca</th>
                                            <th class="center">Modelo</th>
                                            <th class="center">Anio fabricacion</th>
                                            <th class="center"><i class="fa fa-eraser"></i></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    
                                    <?php
                                    
									$rs=fn_mostrar_equipos($id_personal);
									$rows=mysql_num_rows($rs);

									for($i=0;$i<=($rows-1);$i++)
										{
										echo "<tr class='odd gradeX'>\n";
										echo "<td>".mysql_result($rs,$i,"marca")."</td>\n";
										echo "<td>".mysql_result($rs,$i,"modelo")."</td>\n";
										echo "<td>".mysql_result($rs,$i,"anio")."</td>\n";
										echo "<td><a id='' onClick='modalon();' class='btn btn-danger btn-circle'><i class='fa fa-eraser'></i></a></td>\n";
										echo "</tr>\n";
										}
									
									?>
                                
                                
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.table-responsive -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
                    
                    
                    <a href="cita.php?c=0" class="btn btn-lg btn-success">Nueva Cita <i class="fa fa-arrow-circle-o-right fa-fw"></i></a>
                    <hr>
                    
                    <button class="btn btn-danger btn-circle" type="button" data-toggle="modal" data-target="#myModal"><i class="fa fa-eraser"></i></button>
                    
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->
			
            
        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
    
    <!-- Modal -->
      <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only"></span></button>
            <h4 class="modal-title" id="myModalLabel">Mensaje <img src="ico/loading.gif" width="20" height="20"></h4>
          </div>
          
          <div class="modal-body">
            <p>Desea Eliminar la Cita seleccionada? </p>
            
            
          </div>
          <div class="modal-footer">
            
            <!--<a href="citas.php" class="btn btn-default btn-success">Aceptar</a>-->
            <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
    
            <!--<button type="button" class="btn btn-primary">Save changes3</button>-->
          </div>
        </div>
      </div> 
    </div> <!-- Modal -->
    
    

    <!-- jQuery Version 1.11.0 -->
    <script src="js/jquery-1.11.0.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="js/plugins/metisMenu/metisMenu.min.js"></script>

	<!-- DataTables JavaScript -->
    <script src="js/plugins/dataTables/jquery.dataTables.js"></script>
    <script src="js/plugins/dataTables/dataTables.bootstrap.js"></script>


    <!-- Custom Theme JavaScript -->
    <script src="js/sb-admin-2.js"></script>
    
        <!-- Page-Level Demo Scripts - Tables - Use for reference -->
    <script>
    $(document).ready(function() {
        $('#dataTables-example').dataTable();
    });
    </script>

</body>

</html>
