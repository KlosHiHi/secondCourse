var paymentProccessor = new PaymentProccessor();
paymentProccessor.ChangePaymentStrategy(new CardPayment());
paymentProccessor.ProcessPayment(123);

Console.WriteLine();

Blogger iShowMeat = new();
iShowMeat.PublishVideo("первый стрим, не суди строго");

Subscriber panov = new();
iShowMeat.VideoPublished += panov.OnVideoPublished;
iShowMeat.PublishVideo("второй стрим, не суди строго");

Subscriber panov2 = new();
iShowMeat.VideoPublished += panov.OnVideoPublished;
iShowMeat.PublishVideo("третий стрим, не суди строго");

Console.WriteLine();

Sensor sensor = new();
sensor.AddObserver(new TemperatureDisplay() { Sensor = sensor });
sensor.AddObserver(new PressureDisplay() { Sensor = sensor });

sensor.Temperature = 90;
sensor.NotifyObservers();
