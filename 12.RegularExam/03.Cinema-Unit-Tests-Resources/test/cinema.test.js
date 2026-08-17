describe("cinema", () => {
  describe("showMovies", () => {
    it("should return message when array is empty", () => {
     
      const movies = [];
      const expected = 'There are currently no movies to show.'
      const result = cinema.showMovies(movies);

      assert.equal(result, expected);

    });

    it("should return joined movies when array has elements", () => {
      const movies = ['Hot', 'Cold', 'Time to run'];
      const expected = 'Hot, Cold, Time to run'
      const result = cinema.showMovies(movies);

      assert.equal(result, expected);
    });

    it("should return single movie when array has one element", () => {
      const movies = ['Time to run'];
      const expected = 'Time to run'
      const result = cinema.showMovies(movies);

      assert.equal(result, expected);
    });
  });

  describe("ticketPrice", () => {
    it("should return correct price for Premiere", () => {
      const type = 'Premiere';
      const expected = 12.00;
      const result = cinema.ticketPrice(type);

      assert.equal(result, expected);
    });

    it("should return correct price for Normal", () => {
      const type = 'Normal';
      const expected = 7.50;
      const result = cinema.ticketPrice(type);

      assert.equal(result, expected);
    });

    it("should return correct price for Discount", () => {
      const type = 'Discount';
      const expected = 5.50;
      const result = cinema.ticketPrice(type);

      assert.equal(result, expected);
    });

    it("should throw error for invalid projection type", () => {
      const type = 'InvalidType';

      assert.throw(() => cinema.ticketPrice(type),'Invalid projection type.');
    });
  });

  describe("swapSeatsInHall", () => {
    it("should return successful message for valid different integer seats in range", () => {
     
      const firstPlace = 15;
      const secondPlace = 18;

      const expected = "Successful change of seats in the hall."
      const result = cinema.swapSeatsInHall(firstPlace, secondPlace);

      assert.equal(result, expected);
    });

    it("should return unsuccessful message for invalid input types", () => {
      expect(() => cinema.swapSeatsInHall(['arr'], 2).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall('dve',2).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(true, 2).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(null,'dve').equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(undefined,'dve').equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,'dve').equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,['arr']).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,[1]).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,true).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,undefined).equal("Unsuccessful change of seats in the hall."));
      expect(() => cinema.swapSeatsInHall(2,null).equal("Unsuccessful change of seats in the hall."));
    });

    it("should return unsuccessful message for out of range values", () => {
       const firstPlace = 40;
      const secondPlace = 50;

      const expected = "Unsuccessful change of seats in the hall."
      const result = cinema.swapSeatsInHall(firstPlace, secondPlace);

      assert.equal(result, expected);
    });

    it("should return unsuccessful message when seats are the same", () => {
         const firstPlace = 14;
      const secondPlace = 14;

      const expected = "Unsuccessful change of seats in the hall."
      const result = cinema.swapSeatsInHall(firstPlace, secondPlace);

      assert.equal(result, expected);
    });
  });
});