https://github.com/vimn/Project-01-Scripting-2

Tank Controls:
W - Forward
S - Backward
A - Rotate Left
D - Rotate Right
Space - Shoot missile

Innovations:
The missle will split into smaller missiles after traveling for 1 second. 
The main missile will deal 5 damage (sometimes this gets registered more than once, something to fix)
The mini missiles will deal 1 damage each.
Both missiles are inheritors of the projectile class.

The boss will randomly change positions at <20, <15, and <5 health. The completed version the boss will dive under the blue plane, move, and then rise out of the plane.
I have the dive animation working, but the position change occurs while it moves down, something I'm working on fixing. I commented out the dive for now.

