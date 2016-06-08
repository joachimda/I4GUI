function sailboat() {
    var name;
    var lenght;

    //Get and set functions
    this.setName = function(value) {
        name = value;
    }
    this.setLenght = function(value) {
        lenght = value;
    }
    this.getName = function() {
        return name;
    }
    this.getLenght = function() {
        return lenght;
    }

    //Member function to calculate the hullspeed
    this.hullSpeed = function() {
        return 1.34 * Math.sqrt(lenght);
    }
}

