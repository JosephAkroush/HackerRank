void topView(Node root) {
    if (root == null) {
        return;
    }

    directionalView(root.left, "left");
    System.out.print(root.data + " ");
    directionalView(root.right, "right");
}

void directionalView(Node root, String direction) {
    if (root == null) {
        return;
    }

    if (direction.equals("left")) {
        directionalView(root.left, "left");
        System.out.print(root.data + " ");
    } else if (direction.equals("right")) {
        System.out.print(root.data + " ");
        directionalView(root.right, "right");
    }
}
