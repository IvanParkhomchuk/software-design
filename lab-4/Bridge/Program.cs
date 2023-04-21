using Bridge;

Renderer renderer = new RasterRender(new Square());
renderer.Render();

renderer.SetShape(new Tringle());
renderer.Render();

renderer = new VectorSender(new Circle());
renderer.Render();