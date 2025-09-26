<h3>Making the Temple</h3>
<p>To create the temple, I used a mix of Unity's Probuilder, and assets from the Asset Shop.</p>

<h4>The Base</h4>
<p></p>I will start from the bottom up, so first, I'll make the absolute base a big, tilted square.
<p></p>Above the top toolbar, in the options bar, in Unity 6 specifically, I go to Tools> ProBuilder> Editor> Create Shape> Plane and draw a new plane.
<img src="/NewPlane.png">

<p></p>In the inspector, under Pro Builder Shape, I size it 100x by 100z to have a nice flat square.


<p></p>On the side of the viewport, where the transform tools are, I click the top-most tool, the Tool Context, which only appears for probuilder objects
<p></p>I then go to face select in the top toolbar, select all of the faces of the plane, right click and select extrude.
<p></p>For what I'm going for, I only need to extrude only a little, around 2m.


<p></p>I activate the scale tool and scale down the faces slightly to give the sides of the base some inclination.


<p></p>I duplicate the base, set it just above the main base in the y axis, and shrink the entire thing down to make a second base atop the main base


<h4>The Temple</h4>
<p></p>To make the actual temple, I will generate a probuilder cube and scale it 70x by 70z by 9y and place it in the center of the bases.
<p></p>Since I made the bottom bases at the center of the world, so I can simply set the x and z position of the cube to 0 in the transform panel of the inspector


<p></p>I next go into the probuilder's edit mode by clicking the tool context button like before, and go into edge select mode
<p></p>I select the corner edges and bevel to have them flat, all 4 of them


<p></p>After subdividing, I merge the faces on the subdivided edges, making sure there are only 2 verical faces per edge, portrayed on the image


<p></p>Unfortunately, unity keeps the ghost vertices of the now deleted edges of the old faces, so I collapse them to get rid of them
<p></p>Specifically, I do this by clicking the top vertex, then the middle vertex, right clicking, then clicking Collapse.


<p></p>I select the middle edges of the two faces on the cube's corners, all 4 of them again


<p></p>I go into top view and scale them in X and Z until you have a nice corner, preferably inperfect.
<p></p>An L shaped corner, with the corner of the L angled imperfectly so that it is not a perfect 90 degree angle.
<p></p>I personally find it better-looking than a 90 degree angle


<p></p>After, I select the top face and scale down until the cube has a noticeable, but not extreme, tilt, like the bases.


<p></p>Once I have it just like I want it, I duplicate it, scale the entire thing down in X and Z, then place it on top of the first piece.
<p></p>I repeat the step one more time for the top


<h4>The Stairs</h4>
<p></p>Similar to adding a probuilder cube or plane, I add a probuilder stairs object, drawing it on the front side of the temple


<p></p>Regardless of how the stairs look, I first use the rotate and scale tool that first appears after making the stairs, then once they're facing the right way, I use Unity's scale and rotate tool to get the stairs in the right rotation and sclae


<p></p>I make sure the top of the stairs aligns with the top of the temple and the base of the stairs with the base of the temple
<p></p>In the inspector, under Pro Builder shape, I can add more steps, so I did


<p></p>For this temple, I want a pair of stairs, so in top view, I shrink the stairs sideways, then move it to the side
<p></p>I duplicate the stair, and set it opposite of the first stairs to have some space in the middle


<h4>The Shrine</h4>
<p></p>For the final probuilder insertion, I added a probuilder cube
<p></p>I set it in the middle of the world using the transform tab (0x 0z), then place atop the temple manually


<p></p>I move it a little ways back to make space in front of the stairs, then I scale it down


<p></p>After scaling, I go into face select and make the roof a little taller. To prevent having to  scale the entire thing in the Y axis


<p></p>I select 4 faces on the shrine's front and remove them


<p></p>Soon after, I select all faces minus the floor and roof, and extrude to give the walls some depth


<p></p>I go into edge select and select one vertical edge above the new entrance, add an edge loop, and another and add an edge loop
<p></p>I select the new faces and give them some thickness by extruding them

<p></p>Something I notice is that, although the interior is modeled, the interior is completely transparent.


<p></p>I don't quite know to make the backfaces visible, so I did the next best thing:
<p></p>I selected all faces, duplicated them, and flipped their normals to make an interior!


<h4>The Assets</h4>
<p></p>On the top toolbar I go to the Asset Store tab> my assets> I go over to my individual assets> download> import
<p></p>These are the assets I will be using


<p></p>The first assets I will use will be the lanterns
<p></p>I set up some lanterns around the perimeter-


<p></p>then some between the stairs-
<p></p>and, finally, two more inside the shrine


<p></p>Inside the shrine, I put some Korean heritage items to simulate gifts
<p></p>I arrange them in a way that looks as if it were all to honor the dead, even though I know very well none of these items are actual finerary items
<p></p>But it all looks so pretty together!


<h4> The Materials</h4>
<p></p>In the assets folder inside unity, I created a new folder and called it "materials"
<p></p>I entered that folder, and created a new material
<p></p>I set the color and the smoothness to my liking, then I added it to the base to make it appear like fresh stone that hasn't aged
<p></p>I did the same steps for the rest of the probuilder objects, but left the assets with their own materials


<h4>The Exportation</h4>
<p></p>For this next part, I needed to export the temple and its assets over to my teammate so he could finalize the terrain and its details
<p></p>To do that, I needed one more add-on known as FBX Exporter
<p></p>Over at the Package Manager> Unity Registry> FBX Exporter, and then I installed it
<p></p>Installing it allowed me to export the temple into an FBX Binary file
<p></p>Before that, I grouped absolutely everything into their respective categories (temple, assets, etc) using empties
<p></p>Once grouped, I selected the main group, went to GameObjects> Export to FBX> selected the options that applied to my exportation, and of course, exported it
<p></p>The file was too big for github, so I had to make sure my teammate had it through different means of sending

 
