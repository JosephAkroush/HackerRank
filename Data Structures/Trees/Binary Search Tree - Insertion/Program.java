static Node Insert(Node root, int value) {
    if (root == null || root.data == value) {
        root = new Node();
        root.data = value;
    } else if (root.data > value) {
        if (root.left == null) {
            root.left = new Node();
            root.left.data = value;
        } else {
            Insert(root.left, value);
        }
    } else if (root.data < value) {
        if (root.right == null) {
            root.right = new Node();
            root.right.data = value;
        } else {
            Insert(root.right, value);
        }
    }

    return root;
}
