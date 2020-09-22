<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <title>UFO Finder</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootswatch/3.3.7/superhero/bootstrap.min.css">
  <link href="https://fonts.googleapis.com/css?family=Ubuntu" rel="stylesheet">
  <link rel="stylesheet" href="static/css/style.css">
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>

<body>



<div class="wrapper">
          <nav class="navbar navbar-default">
                <div class="container-fluid">
                      <div class="navbar-header">
                          <a class="navbar-brand" href="index.html">UFO Sightings
                              <img class="nav-ufo" src="static/images/ufo.svg">
                          </a>
                      </div>
                </div>
          </nav>

          <div class="hero text-center">
                <h1>UFO Sightings</h1>
                <p>The Truth is Out There</p>
          </div>

  <div class="container">

      <div class="row margin-top-50">
              <div class="col-md-4">
                    <aside class="filters">
                            <div class="panel panel-default">
                                <div class="panel-heading">Filter Search By Category</div>
                                  <div class="panel-body">

                                          <form>
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                          <select type="button" class="form-control btn btn-success" data-toggle="dropdown">
                                                              <option href="#" class="dropdown-item">Date/Time</option>
                                                              <option href="#" class="dropdown-item">City</option>
                                                              <option href="#" class="dropdown-item">State</option>
                                                              <option href="#" class="dropdown-item">Country</option>
                                                              <option href="#" class="dropdown-item">Shape</option>
                                                          </select>
                                                    </div>
                                                          <input type="text" id="input" class="form-control" placeholder="enter here">
                                                </div>
                                          </form>

                                        <button id="filter-btn" type="button" class="btn btn-default">Filter Table</button>

                                  </div>
                            </div>
                      </aside>

                  </div>

        <div class="row margin-top-50">
        <div class="col-md-10">
    </br>
                <div id="table-area" class="">
                        <table id="ufo-table" class="table table-striped">
                                <thead>
                                        <tr>
                                                <th class="table-head">Date</th>
                                                <th class="table-head">City</th>
                                                <th class="table-head">State</th>
                                                <th class="table-head">Country</th>
                                                <th class="table-head">Shape</th>
                                                <th class="table-head">Duration</th>
                                                <th class="table-head">Comments</th>
                                        </tr>
                                </thead>
                                <tbody></tbody>
                        </table>
                </div>
        </div>
        </div>

  <footer class="footer">
      <span class="bottom">UFO Sightings</span>
  </footer>

        </div>
</div>

  <script src="https://cdnjs.cloudflare.com/ajax/libs/d3/4.11.0/d3.js"></script>
  <script src="static/js/data.js"></script>
  <script src="static/js/app.js"></script>

</body>

</html>